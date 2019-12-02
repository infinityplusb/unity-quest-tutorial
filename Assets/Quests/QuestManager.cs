using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestManager : MonoBehaviour
{
    public Quest quest = new Quest();

    // Start is called before the first frame update
    void Start()
    {
	QuestEvent a = quest.AddQuestEvent("test1", "description 1");
	QuestEvent b = quest.AddQuestEvent("test2", "description 2");
	QuestEvent c = quest.AddQuestEvent("test3", "description 3");
	QuestEvent d = quest.AddQuestEvent("test4", "description 4");
	QuestEvent e = quest.AddQuestEvent("test5", "description 5");
	QuestEvent f = quest.AddQuestEvent("test6", "description 6");        

	quest.AddPath(a.GetId(), b.GetId());
	quest.AddPath(b.GetId(), c.GetId());
	quest.AddPath(c.GetId(), d.GetId());
	quest.AddPath(d.GetId(), e.GetId());
	quest.AddPath(e.GetId(), f.GetId());
	quest.AddPath(b.GetId(), f.GetId());

	quest.PrintPath();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
