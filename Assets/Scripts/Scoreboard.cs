
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace jim.Scoreboards
{
   
    public class Scoreboard : MonoBehaviour
{
   [SerializeField] private int maxScoreboardEntries = 5; 
   [SerializeField] private Transform highScoresHolderTransform = null;
   [SerializeField] private GameObject scoreboardEntryObject = null;

   [Header("Pizza")]
  // [SerializeField] ScoreboardEntryData testEntryData = new ScoreboardEntryData();
   
   
       [SerializeField] private string testEntryName = "New Name";
       [SerializeField] private int testEntryScore = 0;

   private string SavePath => $"{Application.persistentDataPath}/highscores.json";

   void Start(){
       ScoreBoardSaveData savedScores = GetSavedScores();
       UpdateUI(savedScores);

       SaveScores(savedScores);
   }

    [ContextMenu("Add Test Entry")]
        public void AddTestEntry()
        {
            addEntry(new ScoreboardEntryData(){
                entryName = testEntryName,
                entryScore = testEntryScore
            });
           // addEntry(new ScoreboardEntryData(testEntryName,testEntryScore));
        
        }

   public void addEntry(ScoreboardEntryData scoreboardEntryData){
       ScoreBoardSaveData savedScores = GetSavedScores();
       bool scoreAdded = false;

       for (int i = 0; i < savedScores.highscores.Count; i++)
       {
           /*
           if(scoreboardEntryData.entryScore > savedScores.highscores[i].entryScore)
           {
               savedScores.highscores.Insert(i, scoreboardEntryData);
               scoreAdded = true;
               break;
           }*/
        
             //scoreboardEntryData.entryScore
           if(testEntryScore > savedScores.highscores[i].entryScore){
               savedScores.highscores.Insert(i, scoreboardEntryData);
               scoreAdded = true;
               break;
           }
       }

       if(!scoreAdded && savedScores.highscores.Count < maxScoreboardEntries){
           savedScores.highscores.Add(scoreboardEntryData);
       }

       if(savedScores.highscores.Count > maxScoreboardEntries){
           savedScores.highscores.RemoveRange(maxScoreboardEntries, savedScores.highscores.Count - maxScoreboardEntries);
       }

       UpdateUI(savedScores);

       SaveScores(savedScores);
   }

   private void UpdateUI(ScoreBoardSaveData savedScores){
       foreach (Transform child in highScoresHolderTransform)
       {
           Destroy(child.gameObject);
       }

       foreach (ScoreboardEntryData highscore in savedScores.highscores)
       {
         GameObject go = Instantiate(scoreboardEntryObject, highScoresHolderTransform);
           go.GetComponent<ScoreboardEntryUI>().Initialise(highscore);
       }
   }

   private ScoreBoardSaveData GetSavedScores(){
       if(!File.Exists(SavePath)){
           File.Create(SavePath).Dispose();
           return new ScoreBoardSaveData();
       }

       using(StreamReader stream = new StreamReader(SavePath)){
           string json = stream.ReadToEnd();
           ScoreBoardSaveData save = JsonUtility.FromJson<ScoreBoardSaveData>(json);
           if (save == null)
           {
               return new ScoreBoardSaveData();
           }else{
           return save;
           }
             //return JsonUtility.FromJson<ScoreBoardSaveData>(json); UNREACHABLE
       }
   }

   private void SaveScores(ScoreBoardSaveData scoreboardSaveData){
       using(StreamWriter stream = new StreamWriter(SavePath)){
           string json = JsonUtility.ToJson(scoreboardSaveData, true);
           stream.Write(json);
       }
   }
}
}