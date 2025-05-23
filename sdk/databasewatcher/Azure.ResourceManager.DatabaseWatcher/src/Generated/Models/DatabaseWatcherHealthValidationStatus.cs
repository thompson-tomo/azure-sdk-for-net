// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DatabaseWatcher.Models
{
    /// <summary> Health validation status. </summary>
    public readonly partial struct DatabaseWatcherHealthValidationStatus : IEquatable<DatabaseWatcherHealthValidationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatabaseWatcherHealthValidationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatabaseWatcherHealthValidationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string TimedOutValue = "TimedOut";

        /// <summary> Health validation has not started. </summary>
        public static DatabaseWatcherHealthValidationStatus NotStarted { get; } = new DatabaseWatcherHealthValidationStatus(NotStartedValue);
        /// <summary> Health validation is running. </summary>
        public static DatabaseWatcherHealthValidationStatus Running { get; } = new DatabaseWatcherHealthValidationStatus(RunningValue);
        /// <summary> Health validation completed successfully. </summary>
        public static DatabaseWatcherHealthValidationStatus Succeeded { get; } = new DatabaseWatcherHealthValidationStatus(SucceededValue);
        /// <summary> Health validation failed. </summary>
        public static DatabaseWatcherHealthValidationStatus Failed { get; } = new DatabaseWatcherHealthValidationStatus(FailedValue);
        /// <summary> Health validation was canceled. </summary>
        public static DatabaseWatcherHealthValidationStatus Canceled { get; } = new DatabaseWatcherHealthValidationStatus(CanceledValue);
        /// <summary> Health validation timed out. </summary>
        public static DatabaseWatcherHealthValidationStatus TimedOut { get; } = new DatabaseWatcherHealthValidationStatus(TimedOutValue);
        /// <summary> Determines if two <see cref="DatabaseWatcherHealthValidationStatus"/> values are the same. </summary>
        public static bool operator ==(DatabaseWatcherHealthValidationStatus left, DatabaseWatcherHealthValidationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatabaseWatcherHealthValidationStatus"/> values are not the same. </summary>
        public static bool operator !=(DatabaseWatcherHealthValidationStatus left, DatabaseWatcherHealthValidationStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DatabaseWatcherHealthValidationStatus"/>. </summary>
        public static implicit operator DatabaseWatcherHealthValidationStatus(string value) => new DatabaseWatcherHealthValidationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatabaseWatcherHealthValidationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatabaseWatcherHealthValidationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
