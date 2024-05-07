using Contracts;

namespace MedicalBlackboard
{
    class Program
    {
        static void Main(string[] args)
        {
            IBlackboard medicalBlackboard = new Blackboard();
            IKnowledgeSource symptomsRecording = new SymptomsRecording(medicalBlackboard);
            IKnowledgeSource diagnostics = new Diagnostics(medicalBlackboard);
            var controller = new Controller(medicalBlackboard, new List<IKnowledgeSource>() {
                symptomsRecording, diagnostics
            });

            controller.StartProcessing();

            // Alle Inhalte des Blackboards ausgeben
            var allKnowledge = medicalBlackboard.GetAllKnowledge();

            Console.WriteLine("Gesammeltes Wissen");
            Console.WriteLine("==================");
            foreach(var knowledge in allKnowledge) {
                Console.WriteLine(knowledge.Name + ": " + knowledge.Description);
            }
        }
    }
}
