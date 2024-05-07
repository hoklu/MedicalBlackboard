using Contracts;

public class Diagnostics : IKnowledgeSource
{
    private IBlackboard blackboard;

    public Diagnostics(IBlackboard blackboard)
    {
        this.blackboard = blackboard;
    }

    public void GenerateKnowledge()
    {
        if (blackboard.GetAllKnowledge().Exists(s => s.Name == "Fieber") 
            && blackboard.GetAllKnowledge().Exists(s => s.Name == "Husten")
            && !blackboard.GetAllKnowledge().Exists(s => s.Name == "Erkältung"))
        {
            blackboard.AddKnowledge(new Knowledge("Erkältung", "Eine häufige Infektionskrankheit der Atemwege."));
        }
    }
}
