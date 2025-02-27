// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum for all Regression models supported by AutoML. </summary>
    public readonly partial struct RegressionModels : IEquatable<RegressionModels>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RegressionModels"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RegressionModels(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ElasticNetValue = "ElasticNet";
        private const string GradientBoostingValue = "GradientBoosting";
        private const string DecisionTreeValue = "DecisionTree";
        private const string KNNValue = "KNN";
        private const string LassoLarsValue = "LassoLars";
        private const string SGDValue = "SGD";
        private const string RandomForestValue = "RandomForest";
        private const string ExtremeRandomTreesValue = "ExtremeRandomTrees";
        private const string LightGBMValue = "LightGBM";
        private const string XGBoostRegressorValue = "XGBoostRegressor";

        /// <summary> Elastic net is a popular type of regularized linear regression that combines two popular penalties, specifically the L1 and L2 penalty functions. </summary>
        public static RegressionModels ElasticNet { get; } = new RegressionModels(ElasticNetValue);
        /// <summary> The technique of transiting week learners into a strong learner is called Boosting. The gradient boosting algorithm process works on this theory of execution. </summary>
        public static RegressionModels GradientBoosting { get; } = new RegressionModels(GradientBoostingValue);
        /// <summary>
        /// Decision Trees are a non-parametric supervised learning method used for both classification and regression tasks.
        /// The goal is to create a model that predicts the value of a target variable by learning simple decision rules inferred from the data features.
        /// </summary>
        public static RegressionModels DecisionTree { get; } = new RegressionModels(DecisionTreeValue);
        /// <summary>
        /// K-nearest neighbors (KNN) algorithm uses &apos;feature similarity&apos; to predict the values of new datapoints
        /// which further means that the new data point will be assigned a value based on how closely it matches the points in the training set.
        /// </summary>
        public static RegressionModels KNN { get; } = new RegressionModels(KNNValue);
        /// <summary> Lasso model fit with Least Angle Regression a.k.a. Lars. It is a Linear Model trained with an L1 prior as regularizer. </summary>
        public static RegressionModels LassoLars { get; } = new RegressionModels(LassoLarsValue);
        /// <summary>
        /// SGD: Stochastic gradient descent is an optimization algorithm often used in machine learning applications
        /// to find the model parameters that correspond to the best fit between predicted and actual outputs.
        /// It&apos;s an inexact but powerful technique.
        /// </summary>
        public static RegressionModels SGD { get; } = new RegressionModels(SGDValue);
        /// <summary>
        /// Random forest is a supervised learning algorithm.
        /// The &quot;forest&quot; it builds, is an ensemble of decision trees, usually trained with the “bagging” method.
        /// The general idea of the bagging method is that a combination of learning models increases the overall result.
        /// </summary>
        public static RegressionModels RandomForest { get; } = new RegressionModels(RandomForestValue);
        /// <summary> Extreme Trees is an ensemble machine learning algorithm that combines the predictions from many decision trees. It is related to the widely used random forest algorithm. </summary>
        public static RegressionModels ExtremeRandomTrees { get; } = new RegressionModels(ExtremeRandomTreesValue);
        /// <summary> LightGBM is a gradient boosting framework that uses tree based learning algorithms. </summary>
        public static RegressionModels LightGBM { get; } = new RegressionModels(LightGBMValue);
        /// <summary> XGBoostRegressor: Extreme Gradient Boosting Regressor is a supervised machine learning model using ensemble of base learners. </summary>
        public static RegressionModels XGBoostRegressor { get; } = new RegressionModels(XGBoostRegressorValue);
        /// <summary> Determines if two <see cref="RegressionModels"/> values are the same. </summary>
        public static bool operator ==(RegressionModels left, RegressionModels right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RegressionModels"/> values are not the same. </summary>
        public static bool operator !=(RegressionModels left, RegressionModels right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RegressionModels"/>. </summary>
        public static implicit operator RegressionModels(string value) => new RegressionModels(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RegressionModels other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RegressionModels other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
