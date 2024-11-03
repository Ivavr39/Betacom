using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace KSRKRZCheck
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace KSRKRZCheck.ObjectRepository
{
    public static class Descriptors
    {
        public static class Portal_Rejestrów_Sądowych
        {
            public static _Implementation._Portal_Rejestrów_Sądowych.__Chrome__Portal_Rejestrów_Sądowych___Start Chrome__Portal_Rejestrów_Sądowych___Start { get; private set; } = new _Implementation._Portal_Rejestrów_Sądowych.__Chrome__Portal_Rejestrów_Sądowych___Start();
        }
    }
}

namespace KSRKRZCheck._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS
    {
        public class __Numer_KRS : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Numer_KRS(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/GmAY9s8ffkKePI_kG4OGJA", DisplayName = "Numer KRS", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS
    {
        public class __Pobierz_JSON : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Pobierz_JSON(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/hKDMu1tXg06LLuruO1bY1Q", DisplayName = "Pobierz JSON", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS
    {
        public class __Rodzaj_Rejestru___Przedsiębiorcy : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Rodzaj_Rejestru___Przedsiębiorcy(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/jmnG4Y0xmEKqaubho_wDtA", DisplayName = "Rodzaj Rejestru - Przedsiębiorcy", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS
    {
        public class __Wyczyść : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Wyczyść(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/vNc_1zRM4UiYS9E83lPBsQ", DisplayName = "Wyczyść", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS
    {
        public class __Wyniki_Wyszukiwania___Brak_Danych : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Wyniki_Wyszukiwania___Brak_Danych(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/5MNRJ1KgTUaRrvUd5xASmQ", DisplayName = "Wyniki Wyszukiwania - Brak Danych", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS
    {
        public class __Wyniki_Wyszukiwania___Tabela : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Wyniki_Wyszukiwania___Tabela(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/srCgK0mzNkGOHk_eW1R54g", DisplayName = "Wyniki Wyszukiwania - Tabela", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS
    {
        public class __Wyszukaj : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Wyszukaj(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/zFXT3GP0EUWVp8_owghLkQ", DisplayName = "Wyszukaj", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS
    {
        public class __Znaleziony_KRS : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Znaleziony_KRS(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/upNH5qoNPki-kPDCinjNCg", DisplayName = "Znaleziony KRS", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy
    {
        public class __Wyszukiwarka_KRS : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Wyszukiwarka_KRS(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/j64mQec_Ok2RGfIKpc0fiA", DisplayName = "Wyszukiwarka KRS", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                Numer_KRS = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Numer_KRS(screenDescriptor, this);
                Pobierz_JSON = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Pobierz_JSON(screenDescriptor, this);
                Rodzaj_Rejestru___Przedsiębiorcy = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Rodzaj_Rejestru___Przedsiębiorcy(screenDescriptor, this);
                Wyczyść = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Wyczyść(screenDescriptor, this);
                Wyniki_Wyszukiwania___Brak_Danych = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Wyniki_Wyszukiwania___Brak_Danych(screenDescriptor, this);
                Wyniki_Wyszukiwania___Tabela = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Wyniki_Wyszukiwania___Tabela(screenDescriptor, this);
                Wyszukaj = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Wyszukaj(screenDescriptor, this);
                Znaleziony_KRS = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Znaleziony_KRS(screenDescriptor, this);
            }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Numer_KRS Numer_KRS { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Pobierz_JSON Pobierz_JSON { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Rodzaj_Rejestru___Przedsiębiorcy Rodzaj_Rejestru___Przedsiębiorcy { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Wyczyść Wyczyść { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Wyniki_Wyszukiwania___Brak_Danych Wyniki_Wyszukiwania___Brak_Danych { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Wyniki_Wyszukiwania___Tabela Wyniki_Wyszukiwania___Tabela { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Wyszukaj Wyszukaj { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy._Wyszukiwarka_KRS.__Znaleziony_KRS Znaleziony_KRS { get; private set; }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start
    {
        public class __Krajowy_Rejestr_Sądowy : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Krajowy_Rejestr_Sądowy(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/ZzkDu_dqnE20YHX-B_sxww", DisplayName = "Krajowy Rejestr Sądowy", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                Wyszukiwarka_KRS = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy.__Wyszukiwarka_KRS(screenDescriptor, this);
            }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Sądowy.__Wyszukiwarka_KRS Wyszukiwarka_KRS { get; private set; }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych
    {
        public class __Brak_Wyników : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Brak_Wyników(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/wji1M5KTC06FwlAydxzGGw", DisplayName = "Brak Wyników", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych
    {
        public class __Identyfikator : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Identyfikator(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/hBzmuZ7IS0yv3mQpmszkSw", DisplayName = "Identyfikator", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych
    {
        public class __Portal_Publiczny : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Portal_Publiczny(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/XPPDb9HFwE6-jaR0Uxt2Cw", DisplayName = "Portal Publiczny", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych
    {
        public class __Wyszukaj : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Wyszukaj(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/vH3NTS3KmEeIlrfFBI8LZA", DisplayName = "Wyszukaj", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych
    {
        public class __Wyszukiwanie_Podmiotów : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Wyszukiwanie_Podmiotów(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/SMt9pmAYTUu649m8hpQdtw", DisplayName = "Wyszukiwanie Podmiotów", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start
    {
        public class __Krajowy_Rejestr_Zadłużonych : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Krajowy_Rejestr_Zadłużonych(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/NR49y-aAQEm9Shey71Dq4Q", DisplayName = "Krajowy Rejestr Zadłużonych", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                Brak_Wyników = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych.__Brak_Wyników(screenDescriptor, this);
                Identyfikator = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych.__Identyfikator(screenDescriptor, this);
                Portal_Publiczny = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych.__Portal_Publiczny(screenDescriptor, this);
                Wyszukaj = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych.__Wyszukaj(screenDescriptor, this);
                Wyszukiwanie_Podmiotów = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych.__Wyszukiwanie_Podmiotów(screenDescriptor, this);
            }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych.__Brak_Wyników Brak_Wyników { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych.__Identyfikator Identyfikator { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych.__Portal_Publiczny Portal_Publiczny { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych.__Wyszukaj Wyszukaj { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start._Krajowy_Rejestr_Zadłużonych.__Wyszukiwanie_Podmiotów Wyszukiwanie_Podmiotów { get; private set; }
        }
    }

    namespace _Portal_Rejestrów_Sądowych
    {
        public class __Chrome__Portal_Rejestrów_Sądowych___Start : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Chrome__Portal_Rejestrów_Sądowych___Start()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "fZ-8QgXm3kuyfXKqy9Lojw/8AUvLdrpLUuxJTEixborEA", DisplayName = "Chrome: Portal Rejestrów Sądowych - Start", Screen = this};
                Krajowy_Rejestr_Sądowy = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start.__Krajowy_Rejestr_Sądowy(this, null);
                Krajowy_Rejestr_Zadłużonych = new _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start.__Krajowy_Rejestr_Zadłużonych(this, null);
            }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start.__Krajowy_Rejestr_Sądowy Krajowy_Rejestr_Sądowy { get; private set; }

            public _Implementation._Portal_Rejestrów_Sądowych._Chrome__Portal_Rejestrów_Sądowych___Start.__Krajowy_Rejestr_Zadłużonych Krajowy_Rejestr_Zadłużonych { get; private set; }
        }
    }
}