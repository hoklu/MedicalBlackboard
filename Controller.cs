using Contracts;

public class Controller {
    private List<IKnowledgeSource> knowledgeSources;
    private IBlackboard blackboard;

    public Controller(IBlackboard blackboard, List<IKnowledgeSource> knowledgeSources)
    {
        this.knowledgeSources = knowledgeSources;
        this.blackboard = blackboard;
    }

    public void StartProcessing()
    {
        for(int i = 0; i < 5; i++) {
            AskEachKnowledgeSourceForNewKnowledge();
        }
    }

    private void AskEachKnowledgeSourceForNewKnowledge() {
        foreach (var knowledgeSource in knowledgeSources)
        {
            knowledgeSource.GenerateKnowledge();
        }
    }
}