﻿using RAD.Domain.Enums.HabitEnums;
using RAD.WebApi.DTOs.Users;

namespace RAD.WebApi.DTOs.Habits;
public class HabitViewModel
{
    public long Id { get; set; }
    public UserViewModel User { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public HabitFrequency Frequenty { get; set; }
    public int Steak { get; set; }
    public int BestSteak { get; set; }
    public DateTime LastCompletedDate { get; set; }
}
