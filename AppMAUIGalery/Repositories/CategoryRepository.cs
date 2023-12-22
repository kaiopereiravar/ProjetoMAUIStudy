using AppMAUIGalery.Models;
using AppMAUIGalery.Views.Components.Cells;
using AppMAUIGalery.Views.Components.Forms;
using AppMAUIGalery.Views.Components.List;
using AppMAUIGalery.Views.Components.Mains;
using AppMAUIGalery.Views.Components.Visuals;
using AppMAUIGalery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGalery.Repositories
{
    internal class CategoryRepository //é uma classe responsavel por guardar todas as categorias(como se fosse um banco de dados)
    {
        public CategoryRepository() { }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "StackLayout",
                        Description = "Organização sequencial dos elementos.",
                        Page = typeof(StackLaoutPage) //com o tipo type, nos vamos receber o tipo que é pra ser instanciado, sendo assim, so vamos instanciar quando o usuario clicar
                    },
                    new Component
                    {
                        Title = "Grid",
                        Description = "Organiza os elementos dentro de uma tabela",
                        Page = typeof(GridLayoutPage)
                    },
                    new Component
                    {
                        Title = "AbsoluteLayout",
                        Description = "Liberdade total para posicionar e dimensionar os elementos na tela.",
                        Page = typeof(AbsoluteLayoutPage)
                    },
                    new Component
                    {
                        Title = "FlexLayout",
                        Description = "Organiza os elementos de forma sequencial com muitaa opções de personalização.",
                        Page = typeof(FlexLayoutPage)
                    }
                }
            });

            categories.Add(new Category()
            {
                Name = "Componentes(Views)",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "BoxView",
                        Description = "Componente que cria uma caixa para ser apresentada.",
                        Page = typeof(BoxViewPage)
                    },
                    new Component
                    {
                        Title = "Label",
                        Description = "Apresenta um texto na tela",
                        Page = typeof(LabelPage)
                    },
                    new Component
                    {
                        Title = "Button",
                        Description = "Apresenta um botão na tela",
                        Page = typeof(ButtonPage)
                    },
                    new Component
                    {
                        Title = "Image",
                        Description = "Apresenta uma imagem na tela",
                        Page = typeof(ImagePage)
                    },
                    new Component
                    {
                        Title = "ImageButton",
                        Description = "Apresenta uma imagem como comportamento de botão",
                        Page = typeof(ImageButtonPage)
                    },
                }
            });

            categories.Add(new Category()
            {
                Name = "Visuais",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "Frame",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(FramePage)
                    },
                    new Component
                    {
                        Title = "Border",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(BorderPage)
                    },
                    new Component
                    {
                        Title = "Shadow",
                        Description = "Adiciona uma sompra ao nosso elemento.",
                        Page = typeof(ShadowPage)
                    },
                }
            });

            categories.Add(new Category()
            {
                Name = "Formularios",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "Entry",
                        Description = "Cria uma caixa de entrada de texto",
                        Page = typeof(EntryPage)
                    },
                    new Component
                    {
                        Title = "Editor",
                        Description = "Cria uma caixa de entrada de texto de multiplas linhas.",
                        Page = typeof(EditorPage)
                    },
                    new Component
                    {
                        Title = "CheckBox",
                        Description = "Cria uma caixa de marcação.",
                        Page = typeof(CheckBoxPage)
                    },
                    new Component
                    {
                        Title = "RadioButton",
                        Description = "Cria uma caixa de marcação de escolha unica.",
                        Page = typeof(RadioButtonPage)
                    },
                    new Component
                    {
                        Title = "Switch",
                        Description = "Caixa de marcação booleana",
                        Page = typeof(SwitchPage)
                    },
                    new Component
                    {
                        Title = "Stepper",
                        Description = "Cria opções de incrementar ou decrementar um número.",
                        Page = typeof(StepperPage)
                    },
                    new Component
                    {
                        Title = "Slider",
                        Description = "Cria barra que incrementa ou decrementa um número.",
                        Page = typeof(SliderPage)
                    },
                    new Component
                    {
                        Title = "TimerPicker",
                        Description = "Seleção da hora e do minuto",
                        Page = typeof(TimerPickerPage)
                    },
                    new Component
                    {
                        Title = "DatePicker",
                        Description = "Seleção de data",
                        Page = typeof(DatePickerPage)
                    },
                    new Component
                    {
                        Title = "SearchBar",
                        Description = "Campo de entrada de texto para pesquisa",
                        Page = typeof(SearchBarPage)
                    },
                    new Component
                    {
                        Title = "Picker",
                        Description = "Exibe uma lista de conteudos atraves de um botão.",
                        Page = typeof(PickerPage)
                    },
                }
            });

            categories.Add(new Category()
            {
                Name = "Células",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "TextCell",
                        Description = "Apresentar até duas labels onde uma é destinada ao titulo e a outra a descrição.",
                        Page = typeof(TextCellPage)
                    },
                    new Component
                    {
                        Title = "ImageCell",
                        Description = "Apresentar uma imagem com duas labels, onde uma destinada para o titulo e a outra para a descrição.",
                        Page = typeof(ImageCellPage)
                    },
                    new Component
                    {
                        Title = "SwitchCell",
                        Description = "Apresenta um label em conjunto com um switch.",
                        Page = typeof(SwitchCellPage)
                    },
                    new Component
                    {
                        Title = "EntryCell",
                        Description = "Apresenta uma label em conjunto com um entry.",
                        Page = typeof(EntryCellPage)
                    },
                    new Component
                    {
                        Title = "ViewCell",
                        Description = "Permite criar a nossa celula com layout personalizado.",
                        Page = typeof(ViewCellPage)
                    },

                }
            });

            categories.Add(new Category()
            {
                Name = "Células",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "TableView",
                        Description = "Apresenta celulas em linhas separadas e permite agrupar por seção.",
                        Page = typeof(TableViewPage)
                    },
                    new Component
                    {
                        Title = "Picker",
                        Description = "Apresenta uma lista de seleção unica.",
                        Page = typeof(PickerListPage)
                    },
                    new Component
                    {
                        Title = "ListView",
                        Description = "Apresenta uma lista itens.",
                        Page = typeof(ListViewPage)
                    },
                    new Component
                    {
                        Title = "CollectionView",
                        Description = "Apresenta uma lista itens.",
                        Page = typeof(CollectionViewPage)
                    },
                    new Component
                    {
                        Title = "CarrouselView",
                        Description = "Apresenta uma lista de itens horizontais com navegação lateral.",
                        Page = typeof(CarrouselViewPage)
                    },
                    new Component
                    {
                        Title = "BindableLayout(Atributo)",
                        Description = "Permitir que os layouts possam apresentar nossas listas e nossas coleções.",
                        Page = typeof(BindableLayoutPage)
                    },
                    new Component
                    {
                        Title = "DataTemplateSelector",
                        Description = "Permitir que os itens possam ser apresentados com layouts diferentes.",
                        Page = typeof(DataTemplateSelectorPage)
                    },
                }
            });

            return categories;
        }
    }
}
