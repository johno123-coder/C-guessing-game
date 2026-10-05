# C-guessing-game
🎲 Guess the number in 6 tries. Built with C# and .NET.
# 🎯 C# Number Guessing Game

A simple console game where you try to guess the secret number before you run out of tries. After each guess, the game tells you if you're too high or too low.

 How to play

1. The game picks a random number between 1 and 10.
2. Type your guess and press Enter.
3. Use the "too high" / "too low" hints to get closer.
4. Find the number within 6 guesses to win!

 Features

- Random secret number each game
- "Too high" / "Too low" hints
- Input validation (typing letters won't crash the game or use up a guess)
- Guess counter
- 6-guess limit

 How to run

You need the [.NET SDK](https://dotnet.microsoft.com/download) installed.

```bash
git clone https://github.com/johno123-coder/csharp-number-guessing-game.git
cd csharp-number-guessing-game
dotnet run
```

 Ideas for the future

- [x] Limit the number of guesses
- [ ] Play again option
