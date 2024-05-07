using Contracts;

public class Blackboard : IBlackboard
{
    private List<Knowledge> knowledges = new List<Knowledge>();

    public void AddKnowledge(Knowledge knowledge)
    {
        this.knowledges.Add(knowledge);
    }

    public List<Knowledge> GetAllKnowledge()
    {
        return this.knowledges;
    }

    public bool HasKnowledge(string knowledgeName)
    {
        return knowledges.Any(k => k.Name == knowledgeName);
    }
}