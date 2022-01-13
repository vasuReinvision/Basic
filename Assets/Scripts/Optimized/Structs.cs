using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
struct FavMovies
{
    public string name;
    public string director;
    public float avgRating;
    public int score;
}
public class Structs : MonoBehaviour
{
    FavMovies[] favMovies;
   
    void Start()
    {
        favMovies = new FavMovies[3];

        FavMovies inception = new FavMovies();
        inception.name = "Inception";
        inception.director = "Christy";
        inception.avgRating = 9.5f;
        inception.score = 222;

        FavMovies dhoom = new FavMovies();
        dhoom.name = "Dhoom";
        dhoom.director = "John";
        dhoom.avgRating = 1.5f;
        dhoom.score = 111;


        FavMovies kaboom = new FavMovies();
        kaboom.name = "Kaboom";
        kaboom.director = "Yaro";
        kaboom.avgRating = 2.5f;
        kaboom.score = 333;

        favMovies[0] = inception;
        favMovies[1] = dhoom;
        favMovies[2] = kaboom;
    }

    private void OnDisable()
    {
        foreach (FavMovies favMovie in favMovies)
        {
            Debug.Log(favMovie.name);
            Debug.Log(favMovie.director);
            Debug.Log(favMovie.avgRating);
            Debug.Log(favMovie.score);
            Debug.Log("--------");
        }
    }
}
