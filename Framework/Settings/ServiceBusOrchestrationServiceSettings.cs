﻿//  ----------------------------------------------------------------------------------
//  Copyright Microsoft Corporation
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  ----------------------------------------------------------------------------------

namespace DurableTask.Settings
{
    using DurableTask.Common;

    /// <summary>
    ///     Configuration for various TaskHubWorker options
    /// </summary>
    public sealed class ServiceBusOrchestrationServiceSettings
    {
        /// <summary>
        ///     Create a TaskHubWorkerSettings object with default settings
        /// </summary>
        public ServiceBusOrchestrationServiceSettings()
        {
            MaxTaskOrchestrationDeliveryCount = FrameworkConstants.MaxDeliveryCount;
            MaxTaskActivityDeliveryCount = FrameworkConstants.MaxDeliveryCount;
            MaxTrackingDeliveryCount = FrameworkConstants.MaxDeliveryCount;
            TaskOrchestrationDispatcherSettings = new TaskOrchestrationDispatcherSettings();
            TaskActivityDispatcherSettings = new TaskActivityDispatcherSettings();
            TrackingDispatcherSettings = new TrackingDispatcherSettings();
            JumpStartSettings = new JumpStartSettings();
            MessageCompressionSettings = new CompressionSettings
            {
                Style = CompressionStyle.Never,
                ThresholdInBytes = 0
            };
        }

        /// <summary>
        ///     Maximum number of times the task orchestration dispatcher will try to
        ///     process an orchestration message before giving up
        /// </summary>
        public int MaxTaskOrchestrationDeliveryCount { get; set; }

        /// <summary>
        ///     Maximum number of times the task activity dispatcher will try to
        ///     process an orchestration message before giving up
        /// </summary>
        public int MaxTaskActivityDeliveryCount { get; set; }

        /// <summary>
        ///     Maximum number of times the tracking dispatcher will try to
        ///     process an orchestration message before giving up
        /// </summary>
        public int MaxTrackingDeliveryCount { get; set; }

        /// <summary>
        /// Gets the message prefetch count
        /// </summary>
        public int PrefetchCount { get; } = 50;

        /// <summary>
        /// Gets the default interval in settings between retries
        /// </summary>
        public int IntervalBetweenRetriesSecs { get; } = 5;

        /// <summary>
        /// Gets the max retries
        /// </summary>
        public int MaxRetries { get; } = 5;

        /// <summary>
        /// Settings for the JumpStartManager
        /// </summary>
        public JumpStartSettings JumpStartSettings { get; private set; }

        /// <summary>
        ///     Settings to configure the Task Orchestration Dispatcher
        /// </summary>
        public TaskOrchestrationDispatcherSettings TaskOrchestrationDispatcherSettings { get; private set; }

        /// <summary>
        ///     Settings to configure the Task Activity Dispatcher
        /// </summary>
        public TaskActivityDispatcherSettings TaskActivityDispatcherSettings { get; private set; }

        /// <summary>
        ///     Settings to configure the Tracking Dispatcher
        /// </summary>
        public TrackingDispatcherSettings TrackingDispatcherSettings { get; private set; }

        /// <summary>
        ///     Enable compression of messages. Allows exchange of larger parameters and return values with activities at the cost
        ///     of additional CPU.
        ///     Default is false.
        /// </summary>
        public CompressionSettings MessageCompressionSettings { get; set; }
    }
}