// <copyright>
// Copyright by ABWE
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;

using Rock;
using Rock.Attribute;
using Rock.Data;
using Rock.Model;
using Rock.Web.Cache;
using Rock.Workflow;

namespace org.abwe.Symphony.Workflow.Action
{
    /// <summary>
    /// Activates a new activity for a given activity type
    /// </summary>
    [ActionCategory("Workflow Control")]
    [Description("Activates a new activity instance and all of its actions based on the front of a csv queue attribute")]
    [Export(typeof(ActionComponent))]
    [ExportMetadata("ComponentName", "Activate Activity From Queue")]

    [WorkflowAttribute("ActivityTypeId Queue", "The attribute containing the ActivityTypeId queue in csv format", true, "", "", 0)]
    [WorkflowAttribute("NumCompletedModules", "The attribute containing the number of completed modules", true, "","",0)]
    [WorkflowActivityType("Default Activity", "The activity type to activate when queue is empty", true, "", "", 0)]

    public class ActivateActivityFromQueue : ActionComponent
    {
        /// <summary>
        /// Executes the specified workflow.
        /// </summary>
        /// <param name="rockContext">The rock context.</param>
        /// <param name="action">The action.</param>
        /// <param name="entity">The entity.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns></returns>
        public override bool Execute(RockContext rockContext, WorkflowAction action, Object entity, out List<string> errorMessages)
        {
            errorMessages = new List<string>();
            var activityTypeIdQueueGuid = GetAttributeValue(action, "ActivityTypeIdQueue").AsGuid();
            string activityTypeIdQueueStr = action.GetWorkflowAttributeValue(activityTypeIdQueueGuid);
            var activityTypeIdQueue = activityTypeIdQueueStr.Split(',').ToList();
            if (activityTypeIdQueueStr.Length == 0 || activityTypeIdQueue.Count == 0)
            {
                // when queue is empty execute the specified default activity
                Guid guid = GetAttributeValue(action, "DefaultActivity").AsGuid();
                if (guid.IsEmpty())
                {
                    action.AddLogEntry("Invalid Default Activity Property", true);
                    return false;
                }

                var aType = WorkflowActivityTypeCache.Get(guid);
                if (aType == null)
                {
                    action.AddLogEntry("Invalid Activity Property", true);
                    return false;
                }

                WorkflowActivity.Activate(aType, action.Activity.Workflow);
                action.AddLogEntry(string.Format("Activated default '{0}' activity", aType.ToString()));

                return true;
            }

            // peek front Id from queue
            int activityTypeId = activityTypeIdQueue[0].AsInteger();
            if (activityTypeId == 0)
            {
                action.AddLogEntry("Invalid ActivityTypeId attribute", true);
                return false;
            }
            // pop front Id from queue
            activityTypeIdQueue.RemoveAt(0);
            string newQueue = String.Join(",", activityTypeIdQueue.Select(x => x.ToString()).ToArray());
            SetWorkflowAttributeValue(action, activityTypeIdQueueGuid, newQueue);
            action.AddLogEntry(string.Format("Set ActivityTypeId Queue to '{0}'", newQueue));

            var numCompletedModulesGuid = GetAttributeValue(action, "NumCompletedModules").AsGuid();
            int numCompletedModules = action.GetWorkflowAttributeValue(numCompletedModulesGuid).AsInteger();
            numCompletedModules++;
            SetWorkflowAttributeValue(action, numCompletedModulesGuid, numCompletedModules.ToString());

            var workflow = action.Activity.Workflow;

            var activityType = WorkflowActivityTypeCache.Get(activityTypeId);
            if (activityType == null)
            {
                action.AddLogEntry("Invalid Activity Property", true);
                return false;
            }

            WorkflowActivity.Activate(activityType, workflow);
            action.AddLogEntry(string.Format("Activated new '{0}' activity", activityType.ToString()));

            return true;
        }

    }
}