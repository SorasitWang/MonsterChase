using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject[] monsterRef;
    private GameObject spawnMonster;
    [SerializeField]
    private Transform leftPos,rightPos;

    private int randomIdx;
    private int randomSide;
    void Start()
    {
         StartCoroutine(SpawnMonster());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator SpawnMonster(){

        while(true){

            yield return new WaitForSeconds(Random.Range(1,5));
            randomIdx = Random.Range(0,monsterRef.Length);
            randomSide = Random.Range(0,2);

            spawnMonster = Instantiate(monsterRef[randomIdx]);
            //left
            if (randomSide==0){
                spawnMonster.transform.position = leftPos.transform.position;
                spawnMonster.GetComponent<Enemy>().speed = Random.Range(4,10);
            }
            else{
                spawnMonster.transform.position = rightPos.transform.position;
                spawnMonster.GetComponent<Enemy>().speed = -Random.Range(4,10);
                spawnMonster.transform.localScale = new Vector3(-1,1,1);
            }
        }

    }

}
