﻿namespace RAD_BackEnd.DTOs.NotesModel;
public class NotesUpdateModel
{
#pragma warning disable
    public long Id { get; set; }
    public long UserId { get; set; }
    public string Body { get; set; }
}