using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnLevel1 : MonoBehaviour
{

    private int x = 4;
    private int y = 1;
    public float lowest;

    public GameObject startBlock; //start Block
    public GameObject[] blockPrefabs; //Prefabs für alle BlockVarianten

    private GameObject currentBlock;
    private GameObject middleBlock;
    private GameObject middlemiddleBlock;
    private GameObject middlemiddlemiddleBlock;
    private GameObject nextBlock; //nächster Block
    


        void Start() //StartBlock
        {

            currentBlock = Instantiate(startBlock, transform.position*20, transform.rotation, transform); // spawned Startblock

            middleBlock = Instantiate(blockPrefabs[Random.Range(0, blockPrefabs.Length)], currentBlock.transform.GetChild(0).transform.position, transform.rotation, transform); // spawned Zweiten Block, zufällige Auswahl

            middlemiddleBlock = Instantiate(blockPrefabs[Random.Range(0, blockPrefabs.Length)], middleBlock.transform.GetChild(0).transform.position, transform.rotation, transform);

            middlemiddlemiddleBlock = Instantiate(blockPrefabs[Random.Range(0, blockPrefabs.Length)], middlemiddleBlock.transform.GetChild(0).transform.position, transform.rotation, transform);

            nextBlock = Instantiate(blockPrefabs[Random.Range(0, blockPrefabs.Length)], middlemiddlemiddleBlock.transform.GetChild(0).transform.position, transform.rotation, transform); // spawned Zweiten Block, zufällige Auswahl

            

            middleBlock.GetComponent<TriggerNextSpawn>().spawner = this; // weist dem Trigger Script dieses Script zu

            middlemiddleBlock.GetComponent<TriggerNextSpawn>().spawner = this;

            middlemiddlemiddleBlock.GetComponent<TriggerNextSpawn>().spawner = this;

            nextBlock.GetComponent<TriggerNextSpawn>().spawner = this; // weist dem Trigger Script dieses Script zu


        }

        
    
        public void SpawnNextBlock()
        {
            //Destroy(currentBlock, 5); // zerstört den alten Block
            currentBlock = middleBlock;

            middleBlock = middlemiddleBlock;

            middlemiddleBlock = middlemiddlemiddleBlock;

            middlemiddlemiddleBlock = nextBlock;

            lowest = nextBlock.transform.position.y;
           
            

            
            nextBlock = Instantiate(blockPrefabs[Random.Range(0, blockPrefabs.Length)], middlemiddlemiddleBlock.transform.GetChild(0).transform.position, transform.rotation, transform); // spawned neuen Block
            nextBlock.GetComponent<TriggerNextSpawn>().spawner = this; // weißt dem Trigger Script vom neuen Block dieses Script zu
                                        
        }

        private void Update()
        {
        
                    if (Input.GetKeyDown(KeyCode.T))
                    {
                        SpawnNextBlock();
                    }

                    if (Input.GetKeyDown(KeyCode.N))
                    {
                        SceneManager.LoadScene(0);
                    }

            
        }
            
    
}
