using System;
using System.Collections.Generic;
using System.Linq;

namespace DrawPicker
{
    class DrawPicker
    {
        EntryCatalogue catalogue;

        public DrawPicker(EntryCatalogue catalogue)
        {
            this.catalogue = catalogue;
        }

        private void CopyEntries(List<Entry> source, List<Entry> target)
        {
            target.Clear();

            foreach(Entry entry in source) {
                target.Add(entry);
            }
        }

        public void PrintResults()
        {
            Random rnd = new Random();
            List<Entry> availableArtists = new List<Entry>(); // Keeps tracks of people who will draw.
            List<Entry> availableTargets = new List<Entry>(); // Keeps tracks of people to be drawn.
            List<Pair<Entry>> results = new List<Pair<Entry>>();

            this.CopyEntries(catalogue.Entries, availableArtists);
            this.CopyEntries(catalogue.Entries, availableTargets);

            while (availableArtists.Count > 0)
            {
                Entry artist = availableArtists[0];
                Entry target = availableTargets[rnd.Next(0, availableArtists.Count)];

                if (artist != target)
                {
                    results.Add(new Pair<Entry>(artist, target));

                    availableArtists.Remove(artist);
                    availableTargets.Remove(target);
                }

                else if(availableArtists.Count == 1)
                {
                    results.Add(new Pair<Entry>(artist, target));

                    availableArtists.Remove(artist);
                    availableTargets.Remove(target);
                }
            }

            // Print the results
            List<Pair<Entry>> sortedResults = results.OrderBy(r => r.ValA.Person.Name).ToList();
            foreach(Pair<Entry> pair in sortedResults){
                Console.WriteLine(String.Format("{0} -> {1}", pair.ValA.Person.Name, pair.ValB.Person.Name));
            }
        }
    }
}
