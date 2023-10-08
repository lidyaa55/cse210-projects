class PromptGenerator
{
    private List<string> prompts;

    public PromptGenerator()
    {
        
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What are your goals and aspirations for the next year, and how can you work toward achieving them?",
            "Describe a recent challenge you faced and how you overcame it.",
            "Write about a person who has had a significant impact on your life and why they are important to you.",
            "What are three things you are grateful for today, and why?",
            "Reflect on a recent accomplishment or success, no matter how small it may seem.",
            "Write about a mistake or failure you've experienced and what you learned from it.",
            "Describe a place that holds special meaning for you and the memories associated with it.",
            "Explore your daily routine and identify any habits you would like to change or improve.",
            "Write a letter to your future self, expressing your hopes, fears, and current aspirations.",
            "How do you manage stress and practice self-care in your life?",
            "What is something you've always wanted to learn or try? Write about why you haven't pursued it yet and how you can start.",
            "Describe a recent book, movie, or piece of art that made a significant impact on you.",
            "Write about a happy childhood memory that still brings you joy.",
            "Reflect on your current relationships and write about ways you can nurture and strengthen them.",
            
            
        };
    }

    public string GetRandomPrompt()
    {
        // Generate and return a random prompt
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
