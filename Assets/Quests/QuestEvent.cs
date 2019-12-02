﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class QuestEvent
{
    public enum EventStatus {WAITING, CURRENT, DONE};

	public string name;
	public string description;
	public string id;
	public int order = -1;
	public EventStatus status;

	public List<QuestPath> pathlist = new List<QuestPath>();

	public QuestEvent(string n, string d)
 	{
		id = Guid.NewGuid().ToString();
		name = n;
		description = d;
		status = EventStatus.WAITING;	
	}

	public void UpdateQuestEvent(EventStatus es)
	{
		status = es;
	}


	public string GetId()
	{
		return id;
	}
}

