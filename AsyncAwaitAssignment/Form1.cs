namespace AsyncAwaitAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileName1.Text = openFileDialog1.FileName.Split("\\").LastOrDefault();
            }

        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileName2.Text = openFileDialog2.FileName.Split("\\").LastOrDefault();
            }

        }
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Task> tasks = new List<Task>();

            var file1 = openFileDialog1.FileName;
            var wordTask1 = ReadBook1(file1);

            var file2 = openFileDialog2.FileName;
            var wordTask2 = ReadBook2(file2);

            tasks.Add(wordTask1);
            tasks.Add(wordTask2);
            await Task.WhenAll(tasks);
            //Other operations after this finished

        }

        private async Task ReadBook1(string filename)
        {
            var lines = await Task.FromResult(File.ReadAllLinesAsync(filename));

            //Now processing the lines and remove spaces and punctuations

            var arrayLinesCleaned = lines.Result.Where(x => x != string.Empty)
                                                .AsParallel()
                                                .Select(x => x.ToLower()
                                                .Trim().Replace(",", "")
                                                .Replace("'", "")
                                                .Replace("{", ""));

            //Now flattening out the array of lines into one array of words 
            var arrayOfWords = arrayLinesCleaned.SelectMany(x => x.Split(" "));

            //Now create a Dictionary which is a list of key, value pairs 
            Dictionary<string, int> wordDic = new Dictionary<string, int>();

            //Convert the Parallel Query into a list to execute the query and then build the Dictionary
            //using an anonymous method

            arrayOfWords.ToList().ForEach(x =>
            {
                if (wordDic.ContainsKey(x))
                    wordDic[x]++;
                else
                    wordDic.Add(x, 1);
            });

            // Get the top 10 words with highest frequency ordered descendingly
            var top10 = wordDic.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                               .OrderByDescending(x => x.Value).Take(10);

            //diplay the top10 elements from the wordDic as a key(word) value(frequency) pairs in the listBox
            foreach (var word in top10)
            {
                listBox1.Items.Add(word.Key + " - " + word.Value);
            }

        }

        private async Task ReadBook2(string filename)
        {
            var lines = await Task.FromResult(File.ReadAllLinesAsync(filename));

            //Now processing the lines and remove spaces and punctuations

            var arrayLinesCleaned = lines.Result.Where(x => x != string.Empty)
                                                .AsParallel()
                                                .Select(x => x.ToLower()
                                                .Trim().Replace(",", "")
                                                .Replace("'", "")
                                                .Replace("{", ""));

            //Now flattening out the array of lines into one array of words 
            var arrayOfWords = arrayLinesCleaned.SelectMany(x => x.Split(" "));

            //Now create a Dictionary which is a list of key, value pairs 
            Dictionary<string, int> wordDic = new Dictionary<string, int>();

            //Convert the Parallel Query into a list to execute the query and then build the Dictionary
            //using an anonymous method

            arrayOfWords.ToList().ForEach(x =>
            {
                if (wordDic.ContainsKey(x))
                    wordDic[x]++;
                else
                    wordDic.Add(x, 1);
            });

            // Get the top 10 words with highest frequency ordered descendingly
            var top10 = wordDic.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                               .OrderByDescending(x => x.Value).Take(10);

            //diplay the top10 elements from the wordDic as a key(word) value(frequency) pairs in the listBox
            foreach (var word in top10)
            {
                listBox2.Items.Add(word.Key + " - " + word.Value);
            }

        }
    }
}
