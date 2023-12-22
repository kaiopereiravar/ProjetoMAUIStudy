using AppJogoForca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJogoForca.Repositories
{
    public class WordRepositories
    {
        private List<Word> _words;
        
        public WordRepositories()
        {
            _words = new List<Word>();
            _words.Add(new Word("Nome", "Kaio".ToUpper()));
            _words.Add(new Word("Nome", "Nathan".ToUpper()));
            _words.Add(new Word("Nome", "Kaua".ToUpper()));
            _words.Add(new Word("Nome", "Mariana".ToUpper()));
            _words.Add(new Word("Nome", "Renato".ToUpper()));
            _words.Add(new Word("Nome", "Karen".ToUpper()));
            _words.Add(new Word("Nome", "Tatiana".ToUpper()));
            _words.Add(new Word("Nome", "Clovis".ToUpper()));
            _words.Add(new Word("Nome", "Domicio".ToUpper()));
            _words.Add(new Word("Nome", "Antonio".ToUpper()));
            _words.Add(new Word("Nome", "Celina".ToUpper()));
            _words.Add(new Word("Nome", "Isah".ToUpper()));
            _words.Add(new Word("Nome", "Babizinha".ToUpper()));
            _words.Add(new Word("Carro", "Astra".ToUpper()));
            _words.Add(new Word("Carro", "Vectra".ToUpper()));
            _words.Add(new Word("Carro", "Doblo".ToUpper()));
            _words.Add(new Word("Carro", "Fusca".ToUpper()));
            _words.Add(new Word("Carro", "Combi".ToUpper()));
            _words.Add(new Word("Carro", "Captiva".ToUpper()));
            _words.Add(new Word("Carro", "Uno".ToUpper()));
            _words.Add(new Word("Carro", "Ranger".ToUpper()));
            _words.Add(new Word("Vegetal", "Cenoura".ToUpper()));
            _words.Add(new Word("Fruta", "Abacate".ToUpper()));
            _words.Add(new Word("Tempero", "Nordestino".ToUpper()));
            _words.Add(new Word("Tempero", "Bahiano".ToUpper()));
        }

        public Word GetRamdomWord()
        {
            Random rand = new Random();
            var number = rand.Next(0, _words.Count);
            return _words[number];
        }

    }
}
