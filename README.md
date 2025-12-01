🔡 LetterByLetter Array

⏱️ Display Array Elements One by One – C# WinForms Project

LetterByLetter Array is a simple Windows Forms application that animates the elements of a string array by displaying each letter sequentially using a timer.
Perfect for beginners learning timers, arrays, and UI updates in C# WinForms.

🚀 Features

⏱️ Displays letters from an array one by one

🔤 Adjustable array of letters

🎯 Simple and easy-to-understand code

🖥️ Great for learning basic WinForms concepts

📌 How It Works

Define an array of letters: { "b", "e", "h", "s", "a" }.

Press the button to start the timer.

On each timer tick, the next element of the array is displayed on a label.

Stops automatically after showing all elements.

🧠 Core Code
```csharp

string[] item = { "b", "e", "h", "s", "a" };
int index;

private void button1_Click(object sender, EventArgs e)
{
    index = 0;
    timer1.Interval = 1000;
    timer1.Start();
}

private void timer1_Tick(object sender, EventArgs e)
{
    if (index < item.Length)
    {
        label1.Text = item[index];
        index++;
    }
}
```
🛠 Technologies Used

C#

.NET Framework / .NET

Windows Forms (WinForms)

🤝 Contributing

Feel free to open issues or submit pull requests to enhance the project.

⭐ Support

If you find this project helpful, don’t forget to star ⭐ the repository!
