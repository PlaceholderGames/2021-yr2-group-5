using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenteceCheck : MonoBehaviour
{
    public ItemCheck[] _loc;

    public void Check()
    {
        int i = 0;
        int count = 0;
        while (i < _loc.Length)
        {
            if (_loc[i].getItem() == true)
            {
                count++;
            }
            else { i = _loc.Length; }
            if (count == _loc.Length - 1)
            {
                print("Winner Winner Chicken Dinner");
                SceneManager.LoadScene(2);
            }
        }
    }
}
