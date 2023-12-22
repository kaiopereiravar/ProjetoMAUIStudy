using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGalery.Views.Components.List.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public short LaunchYear { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {LaunchYear}";
        }
    }

    public class GroupMovie : List<Movie>
    {
        public string CompanyName { get; set; }
    }

    public class MovieList
    {
        public static List<GroupMovie> GetGroupList()
        {
            var disneyGroup = new GroupMovie() { CompanyName = "Disney" };
            
            disneyGroup.Add(new Movie()
            {
                Id = 1,
                Name = "O Poderoso Chefão",
                Description = "Don Vito Corleone (Marlon Brando) é o chefe de uma \"família\" de Nova York que está feliz, pois Connie (Talia Shire), sua filha, se casou com Carlo (Gianni Russo). Porém, durante a festa, Bonasera (Salvatore Corsitto) é visto no escritório de Don Corleone pedindo \"justiça\", vingança na verdade contra membros de uma quadrilha",
                LaunchYear = 2022,
                Duration = new TimeSpan(2, 55, 00)
            });
            disneyGroup.Add(new Movie()
            {
                Id = 2,
                Name = "O Mundo Depois de Nós",
                Description = "Após as férias de uma família serem estragadas por conta de um ataque cibernético, eles devem unir forças para se proteger de uma crise.\r\n",
                LaunchYear = 2023,
                Duration = new TimeSpan(2, 18, 00)
            });
            disneyGroup.Add(new Movie()
            {
                Id = 3,
                Name = "Napoleão",
                Description = "O filme é um olhar original e pessoal sobre as origens de Napoleão Bonaparte",
                LaunchYear = 2023,
                Duration = new TimeSpan(2, 38, 00)
            });

            var paramountGroup = new GroupMovie() { CompanyName = "Paramount" };
            paramountGroup.Add(new Movie()
            {
                Id = 4,
                Name = "Jogos Vorazes – A Cantiga dos Pássaros e das Serpentes",
                Description = "A história de Coriolanus Snow antes de ser Presidente Snow. Na décima edição dos Jogos, Snow de dezoito anos de idade deverá mentorar um tributo, mas pega justamente uma garota do Distrito 12, o pior dos piores. Em meio à uma rede de traições, manipulações e farsas, Snow deverá não só proteger si mesmo, mas terá que fazer com que a garota chegue até o final da competição.",
                LaunchYear = 2023,
                Duration = new TimeSpan(2, 38, 00)
            });
            paramountGroup.Add(new Movie()
            {
                Id = 5,
                Name = "O Sequestro do Voo 375",
                Description = "Nonato passa por dificuldades financeiras e sem chances de encontrar um emprego em pouco tempo. Ele então decide protestar de modo dramático: sequestrar um voo e jogar o avião no Palácio do Planalto.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1, 40, 00)
            });
            paramountGroup.Add(new Movie()
            {
                Id = 6,
                Name = "Five Nights At Freddy's - O Pesadelo Sem Fim",
                Description = "Recém-contratado como vigia noturno de uma pizzaria, um jovem precisa lutar para sobreviver quando descobre que o local esconde um segredo obscuro.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1, 50, 00)
            });
            paramountGroup.Add(new Movie()
            {
                Id = 7,
                Name = "Trolls 3 - Juntos Novamente",
                Description = "Terceiro filme da franquia Trolls.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1, 32, 00)
            });

            var universalGroup = new GroupMovie() { CompanyName = "Universal" };
            universalGroup.Add(new Movie()
            {
                Id = 8,
                Name = "O Protetor: Capítulo Final",
                Description = "Terceiro filme de O Protetor estrelado por Denzel Washington.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1, 50, 00)
            });
            universalGroup.Add(new Movie()
            {
                Id = 9,
                Name = "Feriado Sangrento",
                Description = "Uma pacata cidade dos Estados Unidos começa a ser aterrorizada por um serial killer com planos macabros.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1, 47, 00)
            });
            universalGroup.Add(new Movie()
            {
                Id = 10,
                Name = "Ó Paí, Ó 2",
                Description = "Sequência do longa Ó Pai, Ó (2007), protagonizado por Lázaro Ramos.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1, 30, 00)
            });

            var list = new List<GroupMovie>()
            {
                disneyGroup,
                paramountGroup,
                universalGroup
            };

            return list;

        }

        public static List<Movie> GetList()
        {
            var list = new List<Movie>();
            list.Add(new Movie()
            {
                Id = 1,
                Name = "O Poderoso Chefão",
                Description = "Don Vito Corleone (Marlon Brando) é o chefe de uma \"família\" de Nova York que está feliz, pois Connie (Talia Shire), sua filha, se casou com Carlo (Gianni Russo). Porém, durante a festa, Bonasera (Salvatore Corsitto) é visto no escritório de Don Corleone pedindo \"justiça\", vingança na verdade contra membros de uma quadrilha",
                LaunchYear = 2022,
                Duration = new TimeSpan(2,55,00)
            });
            list.Add(new Movie()
            {
                Id = 2,
                Name = "O Mundo Depois de Nós",
                Description = "Após as férias de uma família serem estragadas por conta de um ataque cibernético, eles devem unir forças para se proteger de uma crise.\r\n",
                LaunchYear = 2023,
                Duration = new TimeSpan(2,18,00)
            });
            list.Add(new Movie()
            {
                Id = 3,
                Name = "Napoleão",
                Description = "O filme é um olhar original e pessoal sobre as origens de Napoleão Bonaparte",
                LaunchYear = 2023,
                Duration = new TimeSpan(2,38,00)
            });
            list.Add(new Movie()
            {
                Id = 4,
                Name = "Jogos Vorazes – A Cantiga dos Pássaros e das Serpentes",
                Description = "A história de Coriolanus Snow antes de ser Presidente Snow. Na décima edição dos Jogos, Snow de dezoito anos de idade deverá mentorar um tributo, mas pega justamente uma garota do Distrito 12, o pior dos piores. Em meio à uma rede de traições, manipulações e farsas, Snow deverá não só proteger si mesmo, mas terá que fazer com que a garota chegue até o final da competição.",
                LaunchYear = 2023,
                Duration = new TimeSpan(2,38,00)
            });
            list.Add(new Movie()
            {
                Id = 5,
                Name = "O Sequestro do Voo 375",
                Description = "Nonato passa por dificuldades financeiras e sem chances de encontrar um emprego em pouco tempo. Ele então decide protestar de modo dramático: sequestrar um voo e jogar o avião no Palácio do Planalto.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1,40,00)
            });
            list.Add(new Movie()
            {
                Id = 6,
                Name = "Five Nights At Freddy's - O Pesadelo Sem Fim",
                Description = "Recém-contratado como vigia noturno de uma pizzaria, um jovem precisa lutar para sobreviver quando descobre que o local esconde um segredo obscuro.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1,50,00)
            });
            list.Add(new Movie()
            {
                Id = 7,
                Name = "Trolls 3 - Juntos Novamente",
                Description = "Terceiro filme da franquia Trolls.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1,32,00)
            });
            list.Add(new Movie()
            {
                Id = 8,
                Name = "O Protetor: Capítulo Final",
                Description = "Terceiro filme de O Protetor estrelado por Denzel Washington.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1,50,00)
            });
            list.Add(new Movie()
            {
                Id = 9,
                Name = "Feriado Sangrento",
                Description = "Uma pacata cidade dos Estados Unidos começa a ser aterrorizada por um serial killer com planos macabros.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1,47,00)
            });
            list.Add(new Movie()
            {
                Id = 10,
                Name = "Ó Paí, Ó 2",
                Description = "Sequência do longa Ó Pai, Ó (2007), protagonizado por Lázaro Ramos.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1,30,00)
            });

            
            return list;
        }
    }
}
