using Contracts;

public class SymptomsRecording : IKnowledgeSource
{
    private IBlackboard blackboard;

    public SymptomsRecording(IBlackboard blackboard)
    {
        this.blackboard = blackboard;
    }

    public void GenerateKnowledge()
    {
        if(!blackboard.HasKnowledge("Fieber")) {
            blackboard.AddKnowledge(new Knowledge("Fieber", "Erhöhte Körpertemperatur"));
        }

        if(!blackboard.HasKnowledge("Husten")) {
            blackboard.AddKnowledge(new Knowledge("Husten", "Trockener Husten"));
        }

        if(!blackboard.HasKnowledge("Schnupfen")) {
            blackboard.AddKnowledge(new Knowledge("Schnupfen", "Laufende Nase"));
        }
    }
}