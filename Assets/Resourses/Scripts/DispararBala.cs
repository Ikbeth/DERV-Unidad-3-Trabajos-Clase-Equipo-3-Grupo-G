using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBala : MonoBehaviour
{
    [SerializeField]
    GameObject arma;
    [SerializeField]
    GameObject Bala_a_Instanciar;

    GameObject Lugar_a_Spawnear;

    int cont_bala;

    private void Awake()
    {
        //Bala_a_Instanciar = Resources.Load("Prefab/Bala") as GameObject;
        Lugar_a_Spawnear = GameObject.Find("SpawnBala");
    }
    // Start is called before the first frame update
    void Start()
    {
        cont_bala = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject bala_clonada = Instantiate(Bala_a_Instanciar,
                Lugar_a_Spawnear.transform.position,
                Lugar_a_Spawnear.transform.rotation);
            bala_clonada.name = "bala_" + cont_bala++;
            Destroy(bala_clonada, 5);
        }
        

    }
}
