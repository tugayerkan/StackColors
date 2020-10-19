using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerControle : MonoBehaviour

{
    public Vector3 defPos;
    public List<Cube> cubes = new List<Cube>();
    public float offset;
    public Cube.CubeColorType color;
    public GameObject player;


    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("GreenTransition"))
        //{
        //    ChangeColor();
        //}
        if (other.CompareTag("Cube"))
        {
           
            Cube cube = other.GetComponent<Cube>();
            if (cube.color== color)
            {
                cube.transform.SetParent(transform);
                Destroy(other);
                AddCube(cube);
            }
            else
            {

                cube.transform.SetParent(transform);
                Destroy(other);
                RemoveCube(cube);
            }
            
            
        }
        
    }

   // private void ChangeColor()
   //{
   //    var newColor= Cube.CubeColorType.green;
   //     newColor== 
        


   // }
   

    private void RemoveCube(Cube cube)
    {
        for (int i = 0; i < cubes.Count; i++)
        {
            float newHeight = cubes[i].transform.localPosition.y - 1 - offset;
            if (cubes[i].transform.localPosition.y==1)
            {
                FindObjectOfType<GameMonitor>().EndGame();
            }
            Vector3 newPos = new Vector3(cubes[i].transform.localPosition.x, newHeight, cubes[i].transform.localPosition.z);

            cubes[i].transform.localPosition = newPos;
            
        }
        cube.transform.localPosition = defPos;
        //if (cube.transform.localPosition.y == 1)
        //{
        //    FindObjectOfType<GameMonitor>().EndGame();
        //}
        cubes.RemoveAt(0);
        

    }
   

    private void AddCube(Cube cube)
    {
        for (int i = 0; i < cubes.Count; i++)
        {
            float newHeight = cubes[i].transform.localPosition.y + 1 + offset;
            Vector3 newPos = new Vector3(cubes[i].transform.localPosition.x, newHeight, cubes[i].transform.localPosition.z);

            cubes[i].transform.localPosition = newPos;
        }
        cube.transform.localPosition = defPos;
        cubes.Insert(0, cube);
       

    }
}

