namespace Contracts
{
    public interface IBlackboard {
        public void AddKnowledge(Knowledge knowledge);
        bool HasKnowledge(string knowledgeKey);

        public List<Knowledge> GetAllKnowledge();
    }
}