
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataRecorder
{
    private string testType;
    
    private readonly List<int> generationCount = new();
    
    private readonly List<float> piratePointsOverGeneration = new();
    private readonly List<float> normalBoatPointsOverGeneration = new();
    
    private readonly List<float> pirateStepsOverGeneration = new();
    private readonly List<float> normalBoatStepsOverGeneration = new();
    
    private readonly List<float> pirateRayRadiusOverGeneration = new();
    private readonly List<float> normalBoatRayRadiusOverGeneration = new();
    
    private readonly List<float> pirateSightOverGeneration = new();
    private readonly List<float> normalBoatSightOverGeneration = new();
    
    private readonly List<float> pirateMovingSpeedOverGeneration = new();
    private readonly List<float> normalBoatMovingSpeedOverGeneration = new();
    
    private readonly List<float> pirateBoxWeightOverGeneration = new();
    private readonly List<float> normalBoatBoxWeightOverGeneration = new();
    
    private readonly List<float> pirateBoatWeightOverGeneration = new();
    private readonly List<float> normalBoatWeightOverGeneration = new();

    public DataRecorder(string testType)
    {
        this.testType = testType;
    }
    
    public void RecordGenerationCount(int count)
    {
        generationCount.Add(count);
    }
    
    public void RecordPiratePoints(float points)
    {
        piratePointsOverGeneration.Add(points);
    }
    
    public void RecordNormalBoatPoints(float points)
    {
        normalBoatPointsOverGeneration.Add(points);
    }
    
    public void RecordPirateSteps(float steps)
    {
        pirateStepsOverGeneration.Add(steps);
    }
    
    public void RecordNormalBoatSteps(float steps)
    {
        normalBoatStepsOverGeneration.Add(steps);
    }
    
    public void RecordPirateRayRadius(float radius)
    {
        pirateRayRadiusOverGeneration.Add(radius);
    }
    
    public void RecordNormalBoatRayRadius(float radius)
    {
        normalBoatRayRadiusOverGeneration.Add(radius);
    }
    
    public void RecordPirateSight(float sight)
    {
        pirateSightOverGeneration.Add(sight);
    }
    
    public void RecordNormalBoatSight(float sight)
    {
        normalBoatSightOverGeneration.Add(sight);
    }
    
    public void RecordPirateMovingSpeed(float speed)
    {
        pirateMovingSpeedOverGeneration.Add(speed);
    }
    
    public void RecordNormalBoatMovingSpeed(float speed)
    {
        normalBoatMovingSpeedOverGeneration.Add(speed);
    }
    
    public void RecordPirateBoxWeight(float weight)
    {
        pirateBoxWeightOverGeneration.Add(weight);
    }
    
    public void RecordNormalBoatBoxWeight(float weight)
    {
        normalBoatBoxWeightOverGeneration.Add(weight);
    }
    
    public void RecordPirateBoatWeight(float weight)
    {
        pirateBoatWeightOverGeneration.Add(weight);
    }
    
    public void RecordNormalBoatWeight(float weight)
    {
        normalBoatWeightOverGeneration.Add(weight);
    }
    
    
    public void ExportData()
    {
        string baseFilePath = Application.dataPath + "/Data/" + testType + "/";
        Directory.CreateDirectory(baseFilePath);
        
        string filePathPirateBoats = baseFilePath + "pirateBoatsData.csv";
        string filePathNormalBoats = baseFilePath + "normalBoatsData.csv";

        using (var writerPirate = new StreamWriter(filePathPirateBoats))
        {
            writerPirate.WriteLine("Generation,Points,Steps,Ray Radius,Sight,Moving Speed,Box Weight,Weight");
            for (int i = 0; i < generationCount.Count; i++)
            {
                writerPirate.WriteLine($"{generationCount[i]}," +
                                       $"{piratePointsOverGeneration[i]}," +
                                       $"{pirateStepsOverGeneration[i]}," +
                                       $"{pirateRayRadiusOverGeneration[i]}," +
                                       $"{pirateSightOverGeneration[i]}," +
                                       $"{pirateMovingSpeedOverGeneration[i]}," +
                                       $"{pirateBoxWeightOverGeneration[i]}," +
                                       $"{pirateBoatWeightOverGeneration[i]}");
            }
        }
        using (var writerNormal = new StreamWriter(filePathNormalBoats))
        {
            writerNormal.WriteLine("Generation,Points,Steps,Ray Radius,Sight,Moving Speed,Box Weight,Weight");
            for (int i = 0; i < generationCount.Count; i++)
            {
                writerNormal.WriteLine($"{generationCount[i]}," +
                                       $"{normalBoatPointsOverGeneration[i]}," +
                                       $"{normalBoatStepsOverGeneration[i]}," +
                                       $"{normalBoatRayRadiusOverGeneration[i]}," +
                                       $"{normalBoatSightOverGeneration[i]}," +
                                       $"{normalBoatMovingSpeedOverGeneration[i]}," +
                                       $"{normalBoatBoxWeightOverGeneration[i]}," +
                                       $"{normalBoatWeightOverGeneration[i]}");
            }
        }
        Debug.Log($"Pirate Boat data exported to {filePathPirateBoats}!");
        Debug.Log($"Normal Boat data exported to {filePathNormalBoats}!");
    }
    
}
