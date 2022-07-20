using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesForEvents : MonoBehaviour
{
    //Why is this good? 
    //The POI's dont care if there is an achievement system. They dont depend on it at all. It can be swapped out or removed as you see fit.
    //You could also update and change how the entire achievement system works and it wouldnt effect the game elements at all.

    //With this system you could create another event like EnemyKilled. Make the achievement system subscribe to it and count how many enemies are killed and after a certain number give an achievement.
    //HOWEVERRRRR calling a loooot of events can decrease your preformance. For something like this, it is no issue, just don't do it every frame. 

    //Also always remove the subscribtion of an observer, just because it is good practice, since not doing it can be a b!tch to debug
    //If you don't do this, you can call the events even when your achievement system has been destroyed.
}
