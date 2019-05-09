using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AC_GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Year25RetirementEnd()
    {
        // Ends the game after the 25 years have passed without another end game being met.
        // Opens another scene and gives a rundown of the players game stats.
    }

    public void HeroPeaceEnd()
    {
        // Ends the game if the difference between the number of heroes and villains in the world is above 100 in the heroes side.
        // Opens another scene and gives a rundown of the players game stats.
    }

    public void VillainDestructionEnd()
    {
        // Ends the game if the difference between the number of heroes and villains in the world is above 100 in the villains side.
        // Opens another scene and gives a rundown of the players game stats.
    }

    public void EarlyRetirementEnd()
    {
        // Ends the game if the players reputation stays low for to long.
        // Opens another scene and gives a rundown of the players game stats.
    }
}
