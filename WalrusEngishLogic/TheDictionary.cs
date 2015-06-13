using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WalrusEngishLogic
{
    public class TheDictionary
    {
        private Dictionary<string, string> _words;
        private List<string> _variants;
        private KeyValuePair<string, string> _currentWord;
        private static readonly string ApplicationDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private readonly Random _random = new Random();
        private const string Extension = ".txt";

        public bool EnglishRussian { get; private set; }
        public string DictionaryFileName { get; private set; }

        public TheDictionary(string dictionaryFileName, bool englishRussian)
        {
            EnglishRussian = englishRussian;
            DictionaryFileName = dictionaryFileName;
            LoadWordsFromFile();
        }

        public static string[] GetAvailableDictionaries()
        {
            var availableFiles = Directory.GetFiles(ApplicationDirectory, "*" + Extension);
            if (!availableFiles.Any())
            {
                MessageBox.Show(string.Format("Мы не нашли ни одного файла со словами (*{0}) в папке {1}.", Extension, ApplicationDirectory),
                "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return availableFiles.Select(Path.GetFileNameWithoutExtension).ToArray();
        }

        private void LoadWordsFromFile()
        {
            try
            {
            _words = new Dictionary<string, string>();
            _variants = new List<string>();

            var dictionaryFilePath = Path.Combine(ApplicationDirectory, DictionaryFileName + Extension);
            if (!File.Exists(dictionaryFilePath))
                throw new FileNotFoundException("Мы не нашли файл словаря: " + dictionaryFilePath);

            var lines = File.ReadAllLines(dictionaryFilePath, Encoding.UTF8);
            foreach (var line in lines)
            {
                var splittedLine = line.Split(new[] {'|'}, 2);
                if (splittedLine.Count() != 2) continue;

                var word = EnglishRussian ? splittedLine[0] : splittedLine[1];
                var translation = EnglishRussian ? splittedLine[1] : splittedLine[0];

                if (_words.ContainsKey(word)) continue;
                
                _words.Add(word, translation);
                _variants.Add(translation);
            }

            if(!_words.Any())
                throw new FileLoadException(string.Format("Мы не нашли ни одного слова в файле {0} :(", dictionaryFilePath));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string CorrectAnswer
        {
            get
            {
                return _currentWord.Value;
            }
        }


        public string GetNextWord()
        {
            if (!_words.Any())
                LoadWordsFromFile();

            var randomWord = _words.ElementAt(_random.Next(_words.Count() - 1));
            _currentWord = new KeyValuePair<string, string>(randomWord.Key, randomWord.Value);
            _words.Remove(randomWord.Key);
            return _currentWord.Key;
        }

        public string[] GetVariants()
        {
            var randomVariants = new string[4];
            var variantsExceptCurrent = _variants.Where(variant => !variant.Equals(_currentWord.Value)).ToArray();
            var randoms = GenerateRandomArray(randomVariants.Count(), variantsExceptCurrent.Count() - 1);
            for (var i = 0; i < randomVariants.Count(); i++)
                randomVariants[i] = variantsExceptCurrent[randoms[i]];
            
            randomVariants[_random.Next(randomVariants.Count() - 1)] = _currentWord.Value;

            return randomVariants;
        }

        private int[] GenerateRandomArray(int count, int maxValue)
        {
            var randomArray = new List<int>();
            do
            {
                var randomValue = _random.Next(maxValue);
                if (!randomArray.Contains(randomValue))
                    randomArray.Add(randomValue);
            } while (randomArray.Count < count);
            return randomArray.ToArray();
        }

        public bool IsAnswerCorrect(string answer)
        {
            return answer.Equals(_currentWord.Value, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
