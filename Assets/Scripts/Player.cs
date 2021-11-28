using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private string playerName;
    [SerializeField] private float speed = 0.92f;
    [SerializeField] private Vector3 direction = new Vector3(1, 1, 2);
    [SerializeField] private int playerLevel = 0;
    [SerializeField] private int playerCoins = 0;
    [SerializeField] private int worldCoins = 0;

    private Vector3 scale = new Vector3(2,4,6); 
    private float exp = 0;

    public void PostExp (float newExp)
    {
        exp += newExp;

        Debug.Log($"La experiencia es = {exp}");
         if (exp <= 100)
         {
            playerLevel += 1;
            exp = 0;
            playerCoins += 10;
            Debug.Log($"Subiste al nivel {playerLevel}");
            Debug.Log("Sumaste 10 monedas");
            Debug.Log($"Te quedo un total de {playerCoins}");
         };
    }



    // Start is called before the first frame update
    void Start()
    {   

        transform.localScale = scale;

    }

    // Update is called once per frame
    void Update()
    {
        PostExp(1.2f);
        transform.position += direction*speed;
    }
}
