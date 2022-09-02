using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : Observer
{
    void Start()
    {
        PlayerPrefs.DeleteAll();
        foreach (var poi in FindObjectsOfType<PointOfInterest>())
        {
            poi.RegisterObserver(this);
        }
    }

    public override void OnNotify(object value, NotificationType nType)
    {
        if (nType == NotificationType.AchievementUnlocked)
        {
            string achievementKey = "achievement-" + value;

            if (PlayerPrefs.GetInt(achievementKey) == 1)
                return;

            PlayerPrefs.SetInt(achievementKey, 1);
            Debug.Log("Unlocked " + value);
            //Notify steam
        }
    }
}

public enum NotificationType
{
    AchievementUnlocked
}
