﻿using System;

namespace ExGens.FiveSquare.Domain
{
  /// <summary>
  /// Represents a check-in
  /// </summary>
  internal readonly struct Checkin
  {
    /// <summary>
    /// Date and tine of the check-in
    /// </summary>
    public DateTime Date { get; }

    /// <summary>
    /// Check-in location
    /// </summary>
    public Place Location { get; }

    public Checkin(DateTime date, Place location)
    {
      Date = date;
      Location = location;
    }

    /// <inheritdoc />
    public override string ToString() => $":{Date} in {Location}";
  }
}