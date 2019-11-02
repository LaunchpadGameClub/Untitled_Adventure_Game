using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

//[CommandInfo("Custom", "Create Puzzle", "Test")]

//Attach this to a game object that then has a list of objects
// (that can be used to solve the puzzle)
//based on the object then execute another flowchart ()
public class PuzzleObject : MonoBehaviour 
{
    //public Flowchart test;
    public List<GameObject> items;
    public List<string> puzzleEndingMessages; //or nodes
    // Start is called before the first frame update
    void Start()
    {
        //test = this.GameObject.Flowchart;
    }

    // Update is called once per frame
    void Update()
    {
        //Fungus.SendFungusMessage("SolvePuzzle");
    }
}
