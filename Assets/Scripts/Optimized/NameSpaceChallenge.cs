using UnityEngine;

struct NameSpaceChallenges
{
    public string FirstName;
    public string LastName;
}

public class NameSpaceChallenge : MonoBehaviour
{
    
    void Start()
    {
        NameSpaceChallenges nameSpaceChallenge = new NameSpaceChallenges();
        nameSpaceChallenge.FirstName = "Jai";
        nameSpaceChallenge.LastName = "Bheem";
        Reinvision.Challenge.NameSpaceImplementation.NameSpaceChallenges nmspchlng = new Reinvision.Challenge.NameSpaceImplementation.NameSpaceChallenges();
        nmspchlng.Initials = "Kittu Maharaj";
        nmspchlng.score = 33;

    }
}
