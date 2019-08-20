/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines how the algorithm is used for a training job.
    /// </summary>
    public partial class TrainingSpecification
    {
        private List<MetricDefinition> _metricDefinitions = new List<MetricDefinition>();
        private List<HyperParameterSpecification> _supportedHyperParameters = new List<HyperParameterSpecification>();
        private List<string> _supportedTrainingInstanceTypes = new List<string>();
        private List<HyperParameterTuningJobObjective> _supportedTuningJobObjectiveMetrics = new List<HyperParameterTuningJobObjective>();
        private bool? _supportsDistributedTraining;
        private List<ChannelSpecification> _trainingChannels = new List<ChannelSpecification>();
        private string _trainingImage;
        private string _trainingImageDigest;

        /// <summary>
        /// Gets and sets the property MetricDefinitions. 
        /// <para>
        /// A list of <code>MetricDefinition</code> objects, which are used for parsing metrics
        /// generated by the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public List<MetricDefinition> MetricDefinitions
        {
            get { return this._metricDefinitions; }
            set { this._metricDefinitions = value; }
        }

        // Check to see if MetricDefinitions property is set
        internal bool IsSetMetricDefinitions()
        {
            return this._metricDefinitions != null && this._metricDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedHyperParameters. 
        /// <para>
        /// A list of the <code>HyperParameterSpecification</code> objects, that define the supported
        /// hyperparameters. This is required if the algorithm supports automatic model tuning.&gt;
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<HyperParameterSpecification> SupportedHyperParameters
        {
            get { return this._supportedHyperParameters; }
            set { this._supportedHyperParameters = value; }
        }

        // Check to see if SupportedHyperParameters property is set
        internal bool IsSetSupportedHyperParameters()
        {
            return this._supportedHyperParameters != null && this._supportedHyperParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedTrainingInstanceTypes. 
        /// <para>
        /// A list of the instance types that this algorithm can use for training.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SupportedTrainingInstanceTypes
        {
            get { return this._supportedTrainingInstanceTypes; }
            set { this._supportedTrainingInstanceTypes = value; }
        }

        // Check to see if SupportedTrainingInstanceTypes property is set
        internal bool IsSetSupportedTrainingInstanceTypes()
        {
            return this._supportedTrainingInstanceTypes != null && this._supportedTrainingInstanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedTuningJobObjectiveMetrics. 
        /// <para>
        /// A list of the metrics that the algorithm emits that can be used as the objective metric
        /// in a hyperparameter tuning job.
        /// </para>
        /// </summary>
        public List<HyperParameterTuningJobObjective> SupportedTuningJobObjectiveMetrics
        {
            get { return this._supportedTuningJobObjectiveMetrics; }
            set { this._supportedTuningJobObjectiveMetrics = value; }
        }

        // Check to see if SupportedTuningJobObjectiveMetrics property is set
        internal bool IsSetSupportedTuningJobObjectiveMetrics()
        {
            return this._supportedTuningJobObjectiveMetrics != null && this._supportedTuningJobObjectiveMetrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportsDistributedTraining. 
        /// <para>
        /// Indicates whether the algorithm supports distributed training. If set to false, buyers
        /// can’t request more than one instance during training.
        /// </para>
        /// </summary>
        public bool SupportsDistributedTraining
        {
            get { return this._supportsDistributedTraining.GetValueOrDefault(); }
            set { this._supportsDistributedTraining = value; }
        }

        // Check to see if SupportsDistributedTraining property is set
        internal bool IsSetSupportsDistributedTraining()
        {
            return this._supportsDistributedTraining.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingChannels. 
        /// <para>
        /// A list of <code>ChannelSpecification</code> objects, which specify the input sources
        /// to be used by the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
        public List<ChannelSpecification> TrainingChannels
        {
            get { return this._trainingChannels; }
            set { this._trainingChannels = value; }
        }

        // Check to see if TrainingChannels property is set
        internal bool IsSetTrainingChannels()
        {
            return this._trainingChannels != null && this._trainingChannels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrainingImage. 
        /// <para>
        /// The Amazon ECR registry path of the Docker image that contains the training algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string TrainingImage
        {
            get { return this._trainingImage; }
            set { this._trainingImage = value; }
        }

        // Check to see if TrainingImage property is set
        internal bool IsSetTrainingImage()
        {
            return this._trainingImage != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingImageDigest. 
        /// <para>
        /// An MD5 hash of the training algorithm that identifies the Docker image used for training.
        /// </para>
        /// </summary>
        [AWSProperty(Max=72)]
        public string TrainingImageDigest
        {
            get { return this._trainingImageDigest; }
            set { this._trainingImageDigest = value; }
        }

        // Check to see if TrainingImageDigest property is set
        internal bool IsSetTrainingImageDigest()
        {
            return this._trainingImageDigest != null;
        }

    }
}