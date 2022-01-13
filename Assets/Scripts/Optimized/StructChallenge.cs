using UnityEngine;

struct Challenge
{
    public string genreType;
    public int starRating;
    public string[] movieNames;
}
public class StructChallenge : MonoBehaviour
{
    public string genreType;
    public int starRating;
    public string[] movieNames;

    private void OnDisable()
    {
        Challenge challenge = new Challenge();
        challenge.movieNames = movieNames;
        challenge.genreType = genreType;
        challenge.starRating = starRating;

        Debug.Log("Movie Name : ");
        Debug.Log("Genre type : " + challenge.genreType);
        Debug.Log("Star rating : " + challenge.starRating);

        foreach(string movieName in challenge.movieNames)
        {
            Debug.Log(movieName);
        }


    }
}
