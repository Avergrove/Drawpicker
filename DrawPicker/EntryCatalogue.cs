using System.Collections.Generic;

namespace DrawPicker
{

    /// <summary>
    /// The entry catalogue helps handle the people that will be entered into the draw raffle.
    /// </summary>
    class EntryCatalogue
    {
        private List<Entry> entries;

        public EntryCatalogue()
        {
            Entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public void RemoveEntry(string personName)
        {
            Entry toRemove = entries.Find(entry => entry.Person.Name.Equals(personName));
            entries.Remove(toRemove);
        }

        internal List<Entry> Entries { get => entries; set => entries = value; }
    }
}
