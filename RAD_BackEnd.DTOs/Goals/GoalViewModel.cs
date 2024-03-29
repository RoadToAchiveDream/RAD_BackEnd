﻿using RAD_BackEnd.Domain.Enums.GoalEnums;
namespace RAD_BackEnd.DTOs.Goals;
public record GoalViewModel(
     long Id,
    long UserId,
    string Title,
    string Description,
    DateTime StartTime,
    DateTime EndTime,
    Status status,
    decimal Progress);