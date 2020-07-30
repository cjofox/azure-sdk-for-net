// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A signal gate determines when to block (gate) incoming media, and when
    /// to allow it through. It gathers input events over the
    /// activationEvaluationWindow, and determines whether to open or close the
    /// gate.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.MediaGraphSignalGateProcessor")]
    public partial class MediaGraphSignalGateProcessor : MediaGraphProcessor
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphSignalGateProcessor
        /// class.
        /// </summary>
        public MediaGraphSignalGateProcessor()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphSignalGateProcessor
        /// class.
        /// </summary>
        /// <param name="name">The name for this processor node.</param>
        /// <param name="inputs">An array of the names of the other nodes in
        /// the media graph, the outputs of which are used as input for this
        /// processor node.</param>
        /// <param name="activationEvaluationWindow">The period of time over
        /// which the gate gathers input events, before evaluating
        /// them.</param>
        /// <param name="activationSignalOffset">Signal offset once the gate is
        /// activated (can be negative). It is an offset between the time the
        /// event is received, and the timestamp of the first media sample (eg.
        /// video frame) that is allowed through by the gate.</param>
        /// <param name="minimumActivationTime">The minimum period for which
        /// the gate remains open, in the absence of subsequent triggers
        /// (events).</param>
        /// <param name="maximumActivationTime">The maximum period for which
        /// the gate remains open, in the presence of subsequent
        /// events.</param>
        public MediaGraphSignalGateProcessor(string name, IList<MediaGraphNodeInput> inputs, string activationEvaluationWindow = default(string), string activationSignalOffset = default(string), string minimumActivationTime = default(string), string maximumActivationTime = default(string))
            : base(name, inputs)
        {
            ActivationEvaluationWindow = activationEvaluationWindow;
            ActivationSignalOffset = activationSignalOffset;
            MinimumActivationTime = minimumActivationTime;
            MaximumActivationTime = maximumActivationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the period of time over which the gate gathers input
        /// events, before evaluating them.
        /// </summary>
        [JsonProperty(PropertyName = "activationEvaluationWindow")]
        public string ActivationEvaluationWindow { get; set; }

        /// <summary>
        /// Gets or sets signal offset once the gate is activated (can be
        /// negative). It is an offset between the time the event is received,
        /// and the timestamp of the first media sample (eg. video frame) that
        /// is allowed through by the gate.
        /// </summary>
        [JsonProperty(PropertyName = "activationSignalOffset")]
        public string ActivationSignalOffset { get; set; }

        /// <summary>
        /// Gets or sets the minimum period for which the gate remains open, in
        /// the absence of subsequent triggers (events).
        /// </summary>
        [JsonProperty(PropertyName = "minimumActivationTime")]
        public string MinimumActivationTime { get; set; }

        /// <summary>
        /// Gets or sets the maximum period for which the gate remains open, in
        /// the presence of subsequent events.
        /// </summary>
        [JsonProperty(PropertyName = "maximumActivationTime")]
        public string MaximumActivationTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}