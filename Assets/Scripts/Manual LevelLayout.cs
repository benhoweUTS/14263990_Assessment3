using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualLevelLayout : MonoBehaviour
{
    [SerializeField]
    private Sprite[] levelTiles = new Sprite[8]; 
    [SerializeField]
    private GameObject topLeftQuad;
    int[,] levelMap =
    {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
    };

    // Start is called before the first frame update
    void Start()
    {
        GameObject trq = GameObject.Instantiate(topLeftQuad);
        trq.transform.position = new Vector3(27, 0, 0);
        trq.transform.rotation = Quaternion.Euler(0, 180, 0);
        GameObject blq = GameObject.Instantiate(topLeftQuad);
        blq.transform.position = new Vector3(0, -29, 0);
        blq.transform.rotation = Quaternion.Euler(180, 0, 0);
        GameObject brq = GameObject.Instantiate(trq);
        brq.transform.position = new Vector3(27, -29, 0);
        brq.transform.rotation = Quaternion.Euler(180, 180, 0);



        /* used to help create original quad
        //loop through 2d array
        for(int i = 0; i < levelMap.GetLength(0); i++){
            for(int j = 0; j < levelMap.GetLength(1); j++){
               //create game object
               GameObject lvlTile = new GameObject("LevelTile");
               //add components (sprite, colliders etc.)
               lvlTile.AddComponent<SpriteRenderer>();
               lvlTile.GetComponent<SpriteRenderer>().sprite = levelTiles[levelMap[i,j]];
               lvlTile.transform.position = new Vector3(j, -i, 0);

            }
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
