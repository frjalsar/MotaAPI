using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MotaAPI
{
    
    public class CompetitionEvents
    {

    }

    /*public class Code {
        public string TheCode { get; set; }
    }*/

    [EdmEntityTypeAttribute(NamespaceName = "AthleticsModel", Name = "Athl_Competition")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class Athl_Competition : EntityObject
    {
        public static Athl_Competition CreateAthl_Competition(global::System.Byte[] timestamp, global::System.String code, global::System.String name, global::System.String location, global::System.DateTime date, global::System.DateTime date2, global::System.DateTime date3, global::System.String organizer, global::System.String director, global::System.String judge, global::System.Int32 outdoorsOrIndoors, global::System.Int32 competitonType, global::System.Int32 fjolditilstiga, global::System.Int32 stigfyrir1saeti, global::System.Int32 stigfyrir2saeti, global::System.Byte allirfastig, global::System.Int32 tegundstigakeppni, global::System.Int32 fjoldibrauta, global::System.Decimal skraningargjaldprgrein, global::System.String undirskriftgjaldkera, global::System.Byte rafmagnstimataka, global::System.String heitiiafrekaskra, global::System.Int32 fjoldiumferdaitaeknigreinum, global::System.Byte staðurgreinainnanbæjarfélags, global::System.DateTime dagsetning4, global::System.DateTime tími, global::System.Decimal skráningargjld_f__boðhlaup, global::System.Byte vantardagogmanud, global::System.Decimal lengdikm, global::System.String systurhlaup1, global::System.String systurhlaup2, global::System.String systurhlaup3, global::System.String hlaupmotifyrra, global::System.Int32 vidbotvtimatoku1, global::System.String greiniafrekaskra, global::System.Byte bokadiafrekaskra, global::System.String vidbotvtimatoku, global::System.Byte endanlegurslitskrad, global::System.DateTime raesitimi, global::System.Byte synaathugasemd, global::System.Byte oldungaflokkar, global::System.Int32 tungumal, global::System.Byte synafelag, global::System.Byte synaheitisveitar, global::System.String taknhlaupsvidinnlestur, global::System.String ensktheitiamoti, global::System.String heitihtmlsidu, global::System.Byte aldursflokkamot, global::System.Byte makeppauppfyrirsig, global::System.Byte ritarablodmedislmeti, global::System.Byte synaland, global::System.String athugasemdaurslitabladi, global::System.Byte reikna_unglingastig, global::System.DateTime dagssídastuppfaert, global::System.DateTime timisídastuppfaert, global::System.Byte bodhlaupmedmismsprettum, global::System.String textividgesti, global::System.Byte synanettotima, global::System.String greiniafrekaskraflogutimi, global::System.Byte notafelagafkeppendaspjaldi, global::System.Byte lokamotivafrekaskrar, global::System.Byte landistadfelags, global::System.Byte ekkibirtaiafrekaskra, global::System.String slodaurslitmots, global::System.Byte synamillitima1, global::System.Byte synamillitima2, global::System.String heitialista, global::System.String keppnisvollur, global::System.Byte floguhlaup, global::System.Int32 nanaritegund, global::System.String hlaupaseria, global::System.String flokkurhlaups, global::System.String tegundmots, global::System.Byte synamillitima3, global::System.Decimal teljarialltaf1, global::System.Byte stofna_nýjan_v_innles_á_millit, global::System.String millitímar_teknir_eftir, global::System.Byte nota_aðeins_ársbesta_við_röðun, global::System.String tímabil_ársbesta_frá_mótsdags, global::System.Byte reikna_IAAF_stig, global::System.Byte má_prenta_úrslit_frá_Scheduler, global::System.Byte synamillitima4, global::System.Byte synamillitima5, global::System.Byte með_rásnúmeri, global::System.Byte sleppa_í_afhendingu_rásnúmera, global::System.Decimal skráningargj__yngri_en_18_ára, global::System.Decimal skráningargj__f_boðhl_y_18_ára, global::System.Int32 competitorsMinimumAge, global::System.Int32 staða_móts, global::System.Int32 entryFeeType, global::System.Decimal entryFeePrClub, global::System.Int32 maxAgeForFee1, global::System.Decimal entryFeePrCompetitor1, global::System.Int32 maxAgeForFee2, global::System.Decimal entryFeePrCompetitor2, global::System.Int32 maxAgeForFee3, global::System.Decimal entryFeePrCompetitor3, global::System.Decimal maximumEntryFeePrCompetitor, global::System.Int32 defaultTabOrderOnEntryForms, global::System.Byte displayColumnForPrizeCeremony, global::System.Byte competitionFinalized)
        {
            Athl_Competition athl_Competition = new Athl_Competition();
            athl_Competition.timestamp = timestamp;
            athl_Competition.Code = code;
            athl_Competition.Name = name;
            athl_Competition.Location = location;
            athl_Competition.Date = date;
            athl_Competition.Date2 = date2;
            athl_Competition.Date3 = date3;
            athl_Competition.Organizer = organizer;
            athl_Competition.Director = director;
            athl_Competition.Judge = judge;
            athl_Competition.OutdoorsOrIndoors = outdoorsOrIndoors;
            athl_Competition.CompetitonType = competitonType;
            athl_Competition.fjolditilstiga = fjolditilstiga;
            athl_Competition.stigfyrir1saeti = stigfyrir1saeti;
            athl_Competition.stigfyrir2saeti = stigfyrir2saeti;
            athl_Competition.allirfastig = allirfastig;
            athl_Competition.tegundstigakeppni = tegundstigakeppni;
            athl_Competition.fjoldibrauta = fjoldibrauta;
            athl_Competition.skraningargjaldprgrein = skraningargjaldprgrein;
            athl_Competition.undirskriftgjaldkera = undirskriftgjaldkera;
            athl_Competition.rafmagnstimataka = rafmagnstimataka;
            athl_Competition.heitiiafrekaskra = heitiiafrekaskra;
            athl_Competition.fjoldiumferdaitaeknigreinum = fjoldiumferdaitaeknigreinum;
            athl_Competition.staðurgreinainnanbæjarfélags = staðurgreinainnanbæjarfélags;
            athl_Competition.dagsetning4 = dagsetning4;
            athl_Competition.Tími = tími;
            athl_Competition.Skráningargjld_f__boðhlaup = skráningargjld_f__boðhlaup;
            athl_Competition.vantardagogmanud = vantardagogmanud;
            athl_Competition.lengdikm = lengdikm;
            athl_Competition.systurhlaup1 = systurhlaup1;
            athl_Competition.systurhlaup2 = systurhlaup2;
            athl_Competition.systurhlaup3 = systurhlaup3;
            athl_Competition.hlaupmotifyrra = hlaupmotifyrra;
            athl_Competition.vidbotvtimatoku1 = vidbotvtimatoku1;
            athl_Competition.greiniafrekaskra = greiniafrekaskra;
            athl_Competition.bokadiafrekaskra = bokadiafrekaskra;
            athl_Competition.vidbotvtimatoku = vidbotvtimatoku;
            athl_Competition.endanlegurslitskrad = endanlegurslitskrad;
            athl_Competition.raesitimi = raesitimi;
            athl_Competition.synaathugasemd = synaathugasemd;
            athl_Competition.oldungaflokkar = oldungaflokkar;
            athl_Competition.tungumal = tungumal;
            athl_Competition.synafelag = synafelag;
            athl_Competition.synaheitisveitar = synaheitisveitar;
            athl_Competition.taknhlaupsvidinnlestur = taknhlaupsvidinnlestur;
            athl_Competition.ensktheitiamoti = ensktheitiamoti;
            athl_Competition.heitihtmlsidu = heitihtmlsidu;
            athl_Competition.aldursflokkamot = aldursflokkamot;
            athl_Competition.makeppauppfyrirsig = makeppauppfyrirsig;
            athl_Competition.ritarablodmedislmeti = ritarablodmedislmeti;
            athl_Competition.synaland = synaland;
            athl_Competition.athugasemdaurslitabladi = athugasemdaurslitabladi;
            athl_Competition.Reikna_unglingastig = reikna_unglingastig;
            athl_Competition.dagssídastuppfaert = dagssídastuppfaert;
            athl_Competition.timisídastuppfaert = timisídastuppfaert;
            athl_Competition.bodhlaupmedmismsprettum = bodhlaupmedmismsprettum;
            athl_Competition.textividgesti = textividgesti;
            athl_Competition.synanettotima = synanettotima;
            athl_Competition.greiniafrekaskraflogutimi = greiniafrekaskraflogutimi;
            athl_Competition.notafelagafkeppendaspjaldi = notafelagafkeppendaspjaldi;
            athl_Competition.lokamotivafrekaskrar = lokamotivafrekaskrar;
            athl_Competition.landistadfelags = landistadfelags;
            athl_Competition.ekkibirtaiafrekaskra = ekkibirtaiafrekaskra;
            athl_Competition.slodaurslitmots = slodaurslitmots;
            athl_Competition.synamillitima1 = synamillitima1;
            athl_Competition.synamillitima2 = synamillitima2;
            athl_Competition.heitialista = heitialista;
            athl_Competition.keppnisvollur = keppnisvollur;
            athl_Competition.floguhlaup = floguhlaup;
            athl_Competition.nanaritegund = nanaritegund;
            athl_Competition.hlaupaseria = hlaupaseria;
            athl_Competition.flokkurhlaups = flokkurhlaups;
            athl_Competition.tegundmots = tegundmots;
            athl_Competition.synamillitima3 = synamillitima3;
            athl_Competition.teljarialltaf1 = teljarialltaf1;
            athl_Competition.Stofna_nýjan_v_innles_á_millit = stofna_nýjan_v_innles_á_millit;
            athl_Competition.Millitímar_teknir_eftir = millitímar_teknir_eftir;
            athl_Competition.Nota_aðeins_ársbesta_við_röðun = nota_aðeins_ársbesta_við_röðun;
            athl_Competition.Tímabil_ársbesta_frá_mótsdags = tímabil_ársbesta_frá_mótsdags;
            athl_Competition.Reikna_IAAF_stig = reikna_IAAF_stig;
            athl_Competition.Má_prenta_úrslit_frá_Scheduler = má_prenta_úrslit_frá_Scheduler;
            athl_Competition.synamillitima4 = synamillitima4;
            athl_Competition.synamillitima5 = synamillitima5;
            athl_Competition.Með_rásnúmeri = með_rásnúmeri;
            athl_Competition.Sleppa_í_afhendingu_rásnúmera = sleppa_í_afhendingu_rásnúmera;
            athl_Competition.Skráningargj__yngri_en_18_ára = skráningargj__yngri_en_18_ára;
            athl_Competition.Skráningargj__f_boðhl_y_18_ára = skráningargj__f_boðhl_y_18_ára;
            athl_Competition.CompetitorsMinimumAge = competitorsMinimumAge;
            athl_Competition.Staða_móts = staða_móts;
            athl_Competition.EntryFeeType = entryFeeType;
            athl_Competition.EntryFeePrClub = entryFeePrClub;
            athl_Competition.MaxAgeForFee1 = maxAgeForFee1;
            athl_Competition.EntryFeePrCompetitor1 = entryFeePrCompetitor1;
            athl_Competition.MaxAgeForFee2 = maxAgeForFee2;
            athl_Competition.EntryFeePrCompetitor2 = entryFeePrCompetitor2;
            athl_Competition.MaxAgeForFee3 = maxAgeForFee3;
            athl_Competition.EntryFeePrCompetitor3 = entryFeePrCompetitor3;
            athl_Competition.MaximumEntryFeePrCompetitor = maximumEntryFeePrCompetitor;
            athl_Competition.DefaultTabOrderOnEntryForms = defaultTabOrderOnEntryForms;
            athl_Competition.DisplayColumnForPrizeCeremony = displayColumnForPrizeCeremony;
            athl_Competition.CompetitionFinalized = competitionFinalized;
            return athl_Competition;
        }


        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte[] timestamp
        {
            get
            {
                return StructuralObject.GetValidValue(_timestamp);
            }
            set
            {
                OntimestampChanging(value);
                ReportPropertyChanging("timestamp");
                _timestamp = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("timestamp");
                OntimestampChanged();
            }
        }
        private global::System.Byte[] _timestamp;
        partial void OntimestampChanging(global::System.Byte[] value);
        partial void OntimestampChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Code
        {
            get
            {
                return _Code;
            }
            set
            {
                if (_Code != value)
                {
                    OnCodeChanging(value);
                    ReportPropertyChanging("Code");
                    _Code = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Code");
                    OnCodeChanged();
                }
            }
        }
        private global::System.String _Code;
        partial void OnCodeChanging(global::System.String value);
        partial void OnCodeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Location
        {
            get
            {
                return _Location;
            }
            set
            {
                OnLocationChanging(value);
                ReportPropertyChanging("Location");
                _Location = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Location");
                OnLocationChanged();
            }
        }
        private global::System.String _Location;
        partial void OnLocationChanging(global::System.String value);
        partial void OnLocationChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date2
        {
            get
            {
                return _Date2;
            }
            set
            {
                OnDate2Changing(value);
                ReportPropertyChanging("Date2");
                _Date2 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date2");
                OnDate2Changed();
            }
        }
        private global::System.DateTime _Date2;
        partial void OnDate2Changing(global::System.DateTime value);
        partial void OnDate2Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date3
        {
            get
            {
                return _Date3;
            }
            set
            {
                OnDate3Changing(value);
                ReportPropertyChanging("Date3");
                _Date3 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date3");
                OnDate3Changed();
            }
        }
        private global::System.DateTime _Date3;
        partial void OnDate3Changing(global::System.DateTime value);
        partial void OnDate3Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Organizer
        {
            get
            {
                return _Organizer;
            }
            set
            {
                OnOrganizerChanging(value);
                ReportPropertyChanging("Organizer");
                _Organizer = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Organizer");
                OnOrganizerChanged();
            }
        }
        private global::System.String _Organizer;
        partial void OnOrganizerChanging(global::System.String value);
        partial void OnOrganizerChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Director
        {
            get
            {
                return _Director;
            }
            set
            {
                OnDirectorChanging(value);
                ReportPropertyChanging("Director");
                _Director = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Director");
                OnDirectorChanged();
            }
        }
        private global::System.String _Director;
        partial void OnDirectorChanging(global::System.String value);
        partial void OnDirectorChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Judge
        {
            get
            {
                return _Judge;
            }
            set
            {
                OnJudgeChanging(value);
                ReportPropertyChanging("Judge");
                _Judge = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Judge");
                OnJudgeChanged();
            }
        }
        private global::System.String _Judge;
        partial void OnJudgeChanging(global::System.String value);
        partial void OnJudgeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 OutdoorsOrIndoors
        {
            get
            {
                return _OutdoorsOrIndoors;
            }
            set
            {
                OnOutdoorsOrIndoorsChanging(value);
                ReportPropertyChanging("OutdoorsOrIndoors");
                _OutdoorsOrIndoors = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OutdoorsOrIndoors");
                OnOutdoorsOrIndoorsChanged();
            }
        }
        private global::System.Int32 _OutdoorsOrIndoors;
        partial void OnOutdoorsOrIndoorsChanging(global::System.Int32 value);
        partial void OnOutdoorsOrIndoorsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 CompetitonType
        {
            get
            {
                return _CompetitonType;
            }
            set
            {
                OnCompetitonTypeChanging(value);
                ReportPropertyChanging("CompetitonType");
                _CompetitonType = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CompetitonType");
                OnCompetitonTypeChanged();
            }
        }
        private global::System.Int32 _CompetitonType;
        partial void OnCompetitonTypeChanging(global::System.Int32 value);
        partial void OnCompetitonTypeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 fjolditilstiga
        {
            get
            {
                return _fjolditilstiga;
            }
            set
            {
                OnfjolditilstigaChanging(value);
                ReportPropertyChanging("fjolditilstiga");
                _fjolditilstiga = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("fjolditilstiga");
                OnfjolditilstigaChanged();
            }
        }
        private global::System.Int32 _fjolditilstiga;
        partial void OnfjolditilstigaChanging(global::System.Int32 value);
        partial void OnfjolditilstigaChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 stigfyrir1saeti
        {
            get
            {
                return _stigfyrir1saeti;
            }
            set
            {
                Onstigfyrir1saetiChanging(value);
                ReportPropertyChanging("stigfyrir1saeti");
                _stigfyrir1saeti = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("stigfyrir1saeti");
                Onstigfyrir1saetiChanged();
            }
        }
        private global::System.Int32 _stigfyrir1saeti;
        partial void Onstigfyrir1saetiChanging(global::System.Int32 value);
        partial void Onstigfyrir1saetiChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 stigfyrir2saeti
        {
            get
            {
                return _stigfyrir2saeti;
            }
            set
            {
                Onstigfyrir2saetiChanging(value);
                ReportPropertyChanging("stigfyrir2saeti");
                _stigfyrir2saeti = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("stigfyrir2saeti");
                Onstigfyrir2saetiChanged();
            }
        }
        private global::System.Int32 _stigfyrir2saeti;
        partial void Onstigfyrir2saetiChanging(global::System.Int32 value);
        partial void Onstigfyrir2saetiChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte allirfastig
        {
            get
            {
                return _allirfastig;
            }
            set
            {
                OnallirfastigChanging(value);
                ReportPropertyChanging("allirfastig");
                _allirfastig = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("allirfastig");
                OnallirfastigChanged();
            }
        }
        private global::System.Byte _allirfastig;
        partial void OnallirfastigChanging(global::System.Byte value);
        partial void OnallirfastigChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 tegundstigakeppni
        {
            get
            {
                return _tegundstigakeppni;
            }
            set
            {
                OntegundstigakeppniChanging(value);
                ReportPropertyChanging("tegundstigakeppni");
                _tegundstigakeppni = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("tegundstigakeppni");
                OntegundstigakeppniChanged();
            }
        }
        private global::System.Int32 _tegundstigakeppni;
        partial void OntegundstigakeppniChanging(global::System.Int32 value);
        partial void OntegundstigakeppniChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 fjoldibrauta
        {
            get
            {
                return _fjoldibrauta;
            }
            set
            {
                OnfjoldibrautaChanging(value);
                ReportPropertyChanging("fjoldibrauta");
                _fjoldibrauta = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("fjoldibrauta");
                OnfjoldibrautaChanged();
            }
        }
        private global::System.Int32 _fjoldibrauta;
        partial void OnfjoldibrautaChanging(global::System.Int32 value);
        partial void OnfjoldibrautaChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal skraningargjaldprgrein
        {
            get
            {
                return _skraningargjaldprgrein;
            }
            set
            {
                OnskraningargjaldprgreinChanging(value);
                ReportPropertyChanging("skraningargjaldprgrein");
                _skraningargjaldprgrein = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("skraningargjaldprgrein");
                OnskraningargjaldprgreinChanged();
            }
        }
        private global::System.Decimal _skraningargjaldprgrein;
        partial void OnskraningargjaldprgreinChanging(global::System.Decimal value);
        partial void OnskraningargjaldprgreinChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String undirskriftgjaldkera
        {
            get
            {
                return _undirskriftgjaldkera;
            }
            set
            {
                OnundirskriftgjaldkeraChanging(value);
                ReportPropertyChanging("undirskriftgjaldkera");
                _undirskriftgjaldkera = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("undirskriftgjaldkera");
                OnundirskriftgjaldkeraChanged();
            }
        }
        private global::System.String _undirskriftgjaldkera;
        partial void OnundirskriftgjaldkeraChanging(global::System.String value);
        partial void OnundirskriftgjaldkeraChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte rafmagnstimataka
        {
            get
            {
                return _rafmagnstimataka;
            }
            set
            {
                OnrafmagnstimatakaChanging(value);
                ReportPropertyChanging("rafmagnstimataka");
                _rafmagnstimataka = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rafmagnstimataka");
                OnrafmagnstimatakaChanged();
            }
        }
        private global::System.Byte _rafmagnstimataka;
        partial void OnrafmagnstimatakaChanging(global::System.Byte value);
        partial void OnrafmagnstimatakaChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String heitiiafrekaskra
        {
            get
            {
                return _heitiiafrekaskra;
            }
            set
            {
                OnheitiiafrekaskraChanging(value);
                ReportPropertyChanging("heitiiafrekaskra");
                _heitiiafrekaskra = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("heitiiafrekaskra");
                OnheitiiafrekaskraChanged();
            }
        }
        private global::System.String _heitiiafrekaskra;
        partial void OnheitiiafrekaskraChanging(global::System.String value);
        partial void OnheitiiafrekaskraChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 fjoldiumferdaitaeknigreinum
        {
            get
            {
                return _fjoldiumferdaitaeknigreinum;
            }
            set
            {
                OnfjoldiumferdaitaeknigreinumChanging(value);
                ReportPropertyChanging("fjoldiumferdaitaeknigreinum");
                _fjoldiumferdaitaeknigreinum = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("fjoldiumferdaitaeknigreinum");
                OnfjoldiumferdaitaeknigreinumChanged();
            }
        }
        private global::System.Int32 _fjoldiumferdaitaeknigreinum;
        partial void OnfjoldiumferdaitaeknigreinumChanging(global::System.Int32 value);
        partial void OnfjoldiumferdaitaeknigreinumChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte staðurgreinainnanbæjarfélags
        {
            get
            {
                return _staðurgreinainnanbæjarfélags;
            }
            set
            {
                OnstaðurgreinainnanbæjarfélagsChanging(value);
                ReportPropertyChanging("staðurgreinainnanbæjarfélags");
                _staðurgreinainnanbæjarfélags = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("staðurgreinainnanbæjarfélags");
                OnstaðurgreinainnanbæjarfélagsChanged();
            }
        }
        private global::System.Byte _staðurgreinainnanbæjarfélags;
        partial void OnstaðurgreinainnanbæjarfélagsChanging(global::System.Byte value);
        partial void OnstaðurgreinainnanbæjarfélagsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime dagsetning4
        {
            get
            {
                return _dagsetning4;
            }
            set
            {
                Ondagsetning4Changing(value);
                ReportPropertyChanging("dagsetning4");
                _dagsetning4 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("dagsetning4");
                Ondagsetning4Changed();
            }
        }
        private global::System.DateTime _dagsetning4;
        partial void Ondagsetning4Changing(global::System.DateTime value);
        partial void Ondagsetning4Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime Tími
        {
            get
            {
                return _Tími;
            }
            set
            {
                OnTímiChanging(value);
                ReportPropertyChanging("Tími");
                _Tími = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Tími");
                OnTímiChanged();
            }
        }
        private global::System.DateTime _Tími;
        partial void OnTímiChanging(global::System.DateTime value);
        partial void OnTímiChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal Skráningargjld_f__boðhlaup
        {
            get
            {
                return _Skráningargjld_f__boðhlaup;
            }
            set
            {
                OnSkráningargjld_f__boðhlaupChanging(value);
                ReportPropertyChanging("Skráningargjld_f__boðhlaup");
                _Skráningargjld_f__boðhlaup = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Skráningargjld_f__boðhlaup");
                OnSkráningargjld_f__boðhlaupChanged();
            }
        }
        private global::System.Decimal _Skráningargjld_f__boðhlaup;
        partial void OnSkráningargjld_f__boðhlaupChanging(global::System.Decimal value);
        partial void OnSkráningargjld_f__boðhlaupChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte vantardagogmanud
        {
            get
            {
                return _vantardagogmanud;
            }
            set
            {
                OnvantardagogmanudChanging(value);
                ReportPropertyChanging("vantardagogmanud");
                _vantardagogmanud = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("vantardagogmanud");
                OnvantardagogmanudChanged();
            }
        }
        private global::System.Byte _vantardagogmanud;
        partial void OnvantardagogmanudChanging(global::System.Byte value);
        partial void OnvantardagogmanudChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal lengdikm
        {
            get
            {
                return _lengdikm;
            }
            set
            {
                OnlengdikmChanging(value);
                ReportPropertyChanging("lengdikm");
                _lengdikm = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("lengdikm");
                OnlengdikmChanged();
            }
        }
        private global::System.Decimal _lengdikm;
        partial void OnlengdikmChanging(global::System.Decimal value);
        partial void OnlengdikmChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String systurhlaup1
        {
            get
            {
                return _systurhlaup1;
            }
            set
            {
                Onsysturhlaup1Changing(value);
                ReportPropertyChanging("systurhlaup1");
                _systurhlaup1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("systurhlaup1");
                Onsysturhlaup1Changed();
            }
        }
        private global::System.String _systurhlaup1;
        partial void Onsysturhlaup1Changing(global::System.String value);
        partial void Onsysturhlaup1Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String systurhlaup2
        {
            get
            {
                return _systurhlaup2;
            }
            set
            {
                Onsysturhlaup2Changing(value);
                ReportPropertyChanging("systurhlaup2");
                _systurhlaup2 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("systurhlaup2");
                Onsysturhlaup2Changed();
            }
        }
        private global::System.String _systurhlaup2;
        partial void Onsysturhlaup2Changing(global::System.String value);
        partial void Onsysturhlaup2Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String systurhlaup3
        {
            get
            {
                return _systurhlaup3;
            }
            set
            {
                Onsysturhlaup3Changing(value);
                ReportPropertyChanging("systurhlaup3");
                _systurhlaup3 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("systurhlaup3");
                Onsysturhlaup3Changed();
            }
        }
        private global::System.String _systurhlaup3;
        partial void Onsysturhlaup3Changing(global::System.String value);
        partial void Onsysturhlaup3Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String hlaupmotifyrra
        {
            get
            {
                return _hlaupmotifyrra;
            }
            set
            {
                OnhlaupmotifyrraChanging(value);
                ReportPropertyChanging("hlaupmotifyrra");
                _hlaupmotifyrra = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("hlaupmotifyrra");
                OnhlaupmotifyrraChanged();
            }
        }
        private global::System.String _hlaupmotifyrra;
        partial void OnhlaupmotifyrraChanging(global::System.String value);
        partial void OnhlaupmotifyrraChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 vidbotvtimatoku1
        {
            get
            {
                return _vidbotvtimatoku1;
            }
            set
            {
                Onvidbotvtimatoku1Changing(value);
                ReportPropertyChanging("vidbotvtimatoku1");
                _vidbotvtimatoku1 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("vidbotvtimatoku1");
                Onvidbotvtimatoku1Changed();
            }
        }
        private global::System.Int32 _vidbotvtimatoku1;
        partial void Onvidbotvtimatoku1Changing(global::System.Int32 value);
        partial void Onvidbotvtimatoku1Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String greiniafrekaskra
        {
            get
            {
                return _greiniafrekaskra;
            }
            set
            {
                OngreiniafrekaskraChanging(value);
                ReportPropertyChanging("greiniafrekaskra");
                _greiniafrekaskra = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("greiniafrekaskra");
                OngreiniafrekaskraChanged();
            }
        }
        private global::System.String _greiniafrekaskra;
        partial void OngreiniafrekaskraChanging(global::System.String value);
        partial void OngreiniafrekaskraChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte bokadiafrekaskra
        {
            get
            {
                return _bokadiafrekaskra;
            }
            set
            {
                OnbokadiafrekaskraChanging(value);
                ReportPropertyChanging("bokadiafrekaskra");
                _bokadiafrekaskra = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("bokadiafrekaskra");
                OnbokadiafrekaskraChanged();
            }
        }
        private global::System.Byte _bokadiafrekaskra;
        partial void OnbokadiafrekaskraChanging(global::System.Byte value);
        partial void OnbokadiafrekaskraChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String vidbotvtimatoku
        {
            get
            {
                return _vidbotvtimatoku;
            }
            set
            {
                OnvidbotvtimatokuChanging(value);
                ReportPropertyChanging("vidbotvtimatoku");
                _vidbotvtimatoku = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("vidbotvtimatoku");
                OnvidbotvtimatokuChanged();
            }
        }
        private global::System.String _vidbotvtimatoku;
        partial void OnvidbotvtimatokuChanging(global::System.String value);
        partial void OnvidbotvtimatokuChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte endanlegurslitskrad
        {
            get
            {
                return _endanlegurslitskrad;
            }
            set
            {
                OnendanlegurslitskradChanging(value);
                ReportPropertyChanging("endanlegurslitskrad");
                _endanlegurslitskrad = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("endanlegurslitskrad");
                OnendanlegurslitskradChanged();
            }
        }
        private global::System.Byte _endanlegurslitskrad;
        partial void OnendanlegurslitskradChanging(global::System.Byte value);
        partial void OnendanlegurslitskradChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime raesitimi
        {
            get
            {
                return _raesitimi;
            }
            set
            {
                OnraesitimiChanging(value);
                ReportPropertyChanging("raesitimi");
                _raesitimi = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("raesitimi");
                OnraesitimiChanged();
            }
        }
        private global::System.DateTime _raesitimi;
        partial void OnraesitimiChanging(global::System.DateTime value);
        partial void OnraesitimiChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte synaathugasemd
        {
            get
            {
                return _synaathugasemd;
            }
            set
            {
                OnsynaathugasemdChanging(value);
                ReportPropertyChanging("synaathugasemd");
                _synaathugasemd = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("synaathugasemd");
                OnsynaathugasemdChanged();
            }
        }
        private global::System.Byte _synaathugasemd;
        partial void OnsynaathugasemdChanging(global::System.Byte value);
        partial void OnsynaathugasemdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte oldungaflokkar
        {
            get
            {
                return _oldungaflokkar;
            }
            set
            {
                OnoldungaflokkarChanging(value);
                ReportPropertyChanging("oldungaflokkar");
                _oldungaflokkar = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("oldungaflokkar");
                OnoldungaflokkarChanged();
            }
        }
        private global::System.Byte _oldungaflokkar;
        partial void OnoldungaflokkarChanging(global::System.Byte value);
        partial void OnoldungaflokkarChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 tungumal
        {
            get
            {
                return _tungumal;
            }
            set
            {
                OntungumalChanging(value);
                ReportPropertyChanging("tungumal");
                _tungumal = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("tungumal");
                OntungumalChanged();
            }
        }
        private global::System.Int32 _tungumal;
        partial void OntungumalChanging(global::System.Int32 value);
        partial void OntungumalChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte synafelag
        {
            get
            {
                return _synafelag;
            }
            set
            {
                OnsynafelagChanging(value);
                ReportPropertyChanging("synafelag");
                _synafelag = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("synafelag");
                OnsynafelagChanged();
            }
        }
        private global::System.Byte _synafelag;
        partial void OnsynafelagChanging(global::System.Byte value);
        partial void OnsynafelagChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte synaheitisveitar
        {
            get
            {
                return _synaheitisveitar;
            }
            set
            {
                OnsynaheitisveitarChanging(value);
                ReportPropertyChanging("synaheitisveitar");
                _synaheitisveitar = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("synaheitisveitar");
                OnsynaheitisveitarChanged();
            }
        }
        private global::System.Byte _synaheitisveitar;
        partial void OnsynaheitisveitarChanging(global::System.Byte value);
        partial void OnsynaheitisveitarChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String taknhlaupsvidinnlestur
        {
            get
            {
                return _taknhlaupsvidinnlestur;
            }
            set
            {
                OntaknhlaupsvidinnlesturChanging(value);
                ReportPropertyChanging("taknhlaupsvidinnlestur");
                _taknhlaupsvidinnlestur = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("taknhlaupsvidinnlestur");
                OntaknhlaupsvidinnlesturChanged();
            }
        }
        private global::System.String _taknhlaupsvidinnlestur;
        partial void OntaknhlaupsvidinnlesturChanging(global::System.String value);
        partial void OntaknhlaupsvidinnlesturChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String ensktheitiamoti
        {
            get
            {
                return _ensktheitiamoti;
            }
            set
            {
                OnensktheitiamotiChanging(value);
                ReportPropertyChanging("ensktheitiamoti");
                _ensktheitiamoti = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ensktheitiamoti");
                OnensktheitiamotiChanged();
            }
        }
        private global::System.String _ensktheitiamoti;
        partial void OnensktheitiamotiChanging(global::System.String value);
        partial void OnensktheitiamotiChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String heitihtmlsidu
        {
            get
            {
                return _heitihtmlsidu;
            }
            set
            {
                OnheitihtmlsiduChanging(value);
                ReportPropertyChanging("heitihtmlsidu");
                _heitihtmlsidu = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("heitihtmlsidu");
                OnheitihtmlsiduChanged();
            }
        }
        private global::System.String _heitihtmlsidu;
        partial void OnheitihtmlsiduChanging(global::System.String value);
        partial void OnheitihtmlsiduChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte aldursflokkamot
        {
            get
            {
                return _aldursflokkamot;
            }
            set
            {
                OnaldursflokkamotChanging(value);
                ReportPropertyChanging("aldursflokkamot");
                _aldursflokkamot = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("aldursflokkamot");
                OnaldursflokkamotChanged();
            }
        }
        private global::System.Byte _aldursflokkamot;
        partial void OnaldursflokkamotChanging(global::System.Byte value);
        partial void OnaldursflokkamotChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte makeppauppfyrirsig
        {
            get
            {
                return _makeppauppfyrirsig;
            }
            set
            {
                OnmakeppauppfyrirsigChanging(value);
                ReportPropertyChanging("makeppauppfyrirsig");
                _makeppauppfyrirsig = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("makeppauppfyrirsig");
                OnmakeppauppfyrirsigChanged();
            }
        }
        private global::System.Byte _makeppauppfyrirsig;
        partial void OnmakeppauppfyrirsigChanging(global::System.Byte value);
        partial void OnmakeppauppfyrirsigChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte ritarablodmedislmeti
        {
            get
            {
                return _ritarablodmedislmeti;
            }
            set
            {
                OnritarablodmedislmetiChanging(value);
                ReportPropertyChanging("ritarablodmedislmeti");
                _ritarablodmedislmeti = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ritarablodmedislmeti");
                OnritarablodmedislmetiChanged();
            }
        }
        private global::System.Byte _ritarablodmedislmeti;
        partial void OnritarablodmedislmetiChanging(global::System.Byte value);
        partial void OnritarablodmedislmetiChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte synaland
        {
            get
            {
                return _synaland;
            }
            set
            {
                OnsynalandChanging(value);
                ReportPropertyChanging("synaland");
                _synaland = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("synaland");
                OnsynalandChanged();
            }
        }
        private global::System.Byte _synaland;
        partial void OnsynalandChanging(global::System.Byte value);
        partial void OnsynalandChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String athugasemdaurslitabladi
        {
            get
            {
                return _athugasemdaurslitabladi;
            }
            set
            {
                OnathugasemdaurslitabladiChanging(value);
                ReportPropertyChanging("athugasemdaurslitabladi");
                _athugasemdaurslitabladi = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("athugasemdaurslitabladi");
                OnathugasemdaurslitabladiChanged();
            }
        }
        private global::System.String _athugasemdaurslitabladi;
        partial void OnathugasemdaurslitabladiChanging(global::System.String value);
        partial void OnathugasemdaurslitabladiChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte Reikna_unglingastig
        {
            get
            {
                return _Reikna_unglingastig;
            }
            set
            {
                OnReikna_unglingastigChanging(value);
                ReportPropertyChanging("Reikna_unglingastig");
                _Reikna_unglingastig = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Reikna_unglingastig");
                OnReikna_unglingastigChanged();
            }
        }
        private global::System.Byte _Reikna_unglingastig;
        partial void OnReikna_unglingastigChanging(global::System.Byte value);
        partial void OnReikna_unglingastigChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime dagssídastuppfaert
        {
            get
            {
                return _dagssídastuppfaert;
            }
            set
            {
                OndagssídastuppfaertChanging(value);
                ReportPropertyChanging("dagssídastuppfaert");
                _dagssídastuppfaert = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("dagssídastuppfaert");
                OndagssídastuppfaertChanged();
            }
        }
        private global::System.DateTime _dagssídastuppfaert;
        partial void OndagssídastuppfaertChanging(global::System.DateTime value);
        partial void OndagssídastuppfaertChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime timisídastuppfaert
        {
            get
            {
                return _timisídastuppfaert;
            }
            set
            {
                OntimisídastuppfaertChanging(value);
                ReportPropertyChanging("timisídastuppfaert");
                _timisídastuppfaert = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("timisídastuppfaert");
                OntimisídastuppfaertChanged();
            }
        }
        private global::System.DateTime _timisídastuppfaert;
        partial void OntimisídastuppfaertChanging(global::System.DateTime value);
        partial void OntimisídastuppfaertChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte bodhlaupmedmismsprettum
        {
            get
            {
                return _bodhlaupmedmismsprettum;
            }
            set
            {
                OnbodhlaupmedmismsprettumChanging(value);
                ReportPropertyChanging("bodhlaupmedmismsprettum");
                _bodhlaupmedmismsprettum = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("bodhlaupmedmismsprettum");
                OnbodhlaupmedmismsprettumChanged();
            }
        }
        private global::System.Byte _bodhlaupmedmismsprettum;
        partial void OnbodhlaupmedmismsprettumChanging(global::System.Byte value);
        partial void OnbodhlaupmedmismsprettumChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String textividgesti
        {
            get
            {
                return _textividgesti;
            }
            set
            {
                OntextividgestiChanging(value);
                ReportPropertyChanging("textividgesti");
                _textividgesti = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("textividgesti");
                OntextividgestiChanged();
            }
        }
        private global::System.String _textividgesti;
        partial void OntextividgestiChanging(global::System.String value);
        partial void OntextividgestiChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte synanettotima
        {
            get
            {
                return _synanettotima;
            }
            set
            {
                OnsynanettotimaChanging(value);
                ReportPropertyChanging("synanettotima");
                _synanettotima = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("synanettotima");
                OnsynanettotimaChanged();
            }
        }
        private global::System.Byte _synanettotima;
        partial void OnsynanettotimaChanging(global::System.Byte value);
        partial void OnsynanettotimaChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String greiniafrekaskraflogutimi
        {
            get
            {
                return _greiniafrekaskraflogutimi;
            }
            set
            {
                OngreiniafrekaskraflogutimiChanging(value);
                ReportPropertyChanging("greiniafrekaskraflogutimi");
                _greiniafrekaskraflogutimi = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("greiniafrekaskraflogutimi");
                OngreiniafrekaskraflogutimiChanged();
            }
        }
        private global::System.String _greiniafrekaskraflogutimi;
        partial void OngreiniafrekaskraflogutimiChanging(global::System.String value);
        partial void OngreiniafrekaskraflogutimiChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte notafelagafkeppendaspjaldi
        {
            get
            {
                return _notafelagafkeppendaspjaldi;
            }
            set
            {
                OnnotafelagafkeppendaspjaldiChanging(value);
                ReportPropertyChanging("notafelagafkeppendaspjaldi");
                _notafelagafkeppendaspjaldi = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("notafelagafkeppendaspjaldi");
                OnnotafelagafkeppendaspjaldiChanged();
            }
        }
        private global::System.Byte _notafelagafkeppendaspjaldi;
        partial void OnnotafelagafkeppendaspjaldiChanging(global::System.Byte value);
        partial void OnnotafelagafkeppendaspjaldiChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte lokamotivafrekaskrar
        {
            get
            {
                return _lokamotivafrekaskrar;
            }
            set
            {
                OnlokamotivafrekaskrarChanging(value);
                ReportPropertyChanging("lokamotivafrekaskrar");
                _lokamotivafrekaskrar = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("lokamotivafrekaskrar");
                OnlokamotivafrekaskrarChanged();
            }
        }
        private global::System.Byte _lokamotivafrekaskrar;
        partial void OnlokamotivafrekaskrarChanging(global::System.Byte value);
        partial void OnlokamotivafrekaskrarChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte landistadfelags
        {
            get
            {
                return _landistadfelags;
            }
            set
            {
                OnlandistadfelagsChanging(value);
                ReportPropertyChanging("landistadfelags");
                _landistadfelags = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("landistadfelags");
                OnlandistadfelagsChanged();
            }
        }
        private global::System.Byte _landistadfelags;
        partial void OnlandistadfelagsChanging(global::System.Byte value);
        partial void OnlandistadfelagsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte ekkibirtaiafrekaskra
        {
            get
            {
                return _ekkibirtaiafrekaskra;
            }
            set
            {
                OnekkibirtaiafrekaskraChanging(value);
                ReportPropertyChanging("ekkibirtaiafrekaskra");
                _ekkibirtaiafrekaskra = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ekkibirtaiafrekaskra");
                OnekkibirtaiafrekaskraChanged();
            }
        }
        private global::System.Byte _ekkibirtaiafrekaskra;
        partial void OnekkibirtaiafrekaskraChanging(global::System.Byte value);
        partial void OnekkibirtaiafrekaskraChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String slodaurslitmots
        {
            get
            {
                return _slodaurslitmots;
            }
            set
            {
                OnslodaurslitmotsChanging(value);
                ReportPropertyChanging("slodaurslitmots");
                _slodaurslitmots = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("slodaurslitmots");
                OnslodaurslitmotsChanged();
            }
        }
        private global::System.String _slodaurslitmots;
        partial void OnslodaurslitmotsChanging(global::System.String value);
        partial void OnslodaurslitmotsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte synamillitima1
        {
            get
            {
                return _synamillitima1;
            }
            set
            {
                Onsynamillitima1Changing(value);
                ReportPropertyChanging("synamillitima1");
                _synamillitima1 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("synamillitima1");
                Onsynamillitima1Changed();
            }
        }
        private global::System.Byte _synamillitima1;
        partial void Onsynamillitima1Changing(global::System.Byte value);
        partial void Onsynamillitima1Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte synamillitima2
        {
            get
            {
                return _synamillitima2;
            }
            set
            {
                Onsynamillitima2Changing(value);
                ReportPropertyChanging("synamillitima2");
                _synamillitima2 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("synamillitima2");
                Onsynamillitima2Changed();
            }
        }
        private global::System.Byte _synamillitima2;
        partial void Onsynamillitima2Changing(global::System.Byte value);
        partial void Onsynamillitima2Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String heitialista
        {
            get
            {
                return _heitialista;
            }
            set
            {
                OnheitialistaChanging(value);
                ReportPropertyChanging("heitialista");
                _heitialista = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("heitialista");
                OnheitialistaChanged();
            }
        }
        private global::System.String _heitialista;
        partial void OnheitialistaChanging(global::System.String value);
        partial void OnheitialistaChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String keppnisvollur
        {
            get
            {
                return _keppnisvollur;
            }
            set
            {
                OnkeppnisvollurChanging(value);
                ReportPropertyChanging("keppnisvollur");
                _keppnisvollur = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("keppnisvollur");
                OnkeppnisvollurChanged();
            }
        }
        private global::System.String _keppnisvollur;
        partial void OnkeppnisvollurChanging(global::System.String value);
        partial void OnkeppnisvollurChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte floguhlaup
        {
            get
            {
                return _floguhlaup;
            }
            set
            {
                OnfloguhlaupChanging(value);
                ReportPropertyChanging("floguhlaup");
                _floguhlaup = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("floguhlaup");
                OnfloguhlaupChanged();
            }
        }
        private global::System.Byte _floguhlaup;
        partial void OnfloguhlaupChanging(global::System.Byte value);
        partial void OnfloguhlaupChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 nanaritegund
        {
            get
            {
                return _nanaritegund;
            }
            set
            {
                OnnanaritegundChanging(value);
                ReportPropertyChanging("nanaritegund");
                _nanaritegund = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("nanaritegund");
                OnnanaritegundChanged();
            }
        }
        private global::System.Int32 _nanaritegund;
        partial void OnnanaritegundChanging(global::System.Int32 value);
        partial void OnnanaritegundChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String hlaupaseria
        {
            get
            {
                return _hlaupaseria;
            }
            set
            {
                OnhlaupaseriaChanging(value);
                ReportPropertyChanging("hlaupaseria");
                _hlaupaseria = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("hlaupaseria");
                OnhlaupaseriaChanged();
            }
        }
        private global::System.String _hlaupaseria;
        partial void OnhlaupaseriaChanging(global::System.String value);
        partial void OnhlaupaseriaChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String flokkurhlaups
        {
            get
            {
                return _flokkurhlaups;
            }
            set
            {
                OnflokkurhlaupsChanging(value);
                ReportPropertyChanging("flokkurhlaups");
                _flokkurhlaups = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("flokkurhlaups");
                OnflokkurhlaupsChanged();
            }
        }
        private global::System.String _flokkurhlaups;
        partial void OnflokkurhlaupsChanging(global::System.String value);
        partial void OnflokkurhlaupsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String tegundmots
        {
            get
            {
                return _tegundmots;
            }
            set
            {
                OntegundmotsChanging(value);
                ReportPropertyChanging("tegundmots");
                _tegundmots = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("tegundmots");
                OntegundmotsChanged();
            }
        }
        private global::System.String _tegundmots;
        partial void OntegundmotsChanging(global::System.String value);
        partial void OntegundmotsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte synamillitima3
        {
            get
            {
                return _synamillitima3;
            }
            set
            {
                Onsynamillitima3Changing(value);
                ReportPropertyChanging("synamillitima3");
                _synamillitima3 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("synamillitima3");
                Onsynamillitima3Changed();
            }
        }
        private global::System.Byte _synamillitima3;
        partial void Onsynamillitima3Changing(global::System.Byte value);
        partial void Onsynamillitima3Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal teljarialltaf1
        {
            get
            {
                return _teljarialltaf1;
            }
            set
            {
                Onteljarialltaf1Changing(value);
                ReportPropertyChanging("teljarialltaf1");
                _teljarialltaf1 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("teljarialltaf1");
                Onteljarialltaf1Changed();
            }
        }
        private global::System.Decimal _teljarialltaf1;
        partial void Onteljarialltaf1Changing(global::System.Decimal value);
        partial void Onteljarialltaf1Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte Stofna_nýjan_v_innles_á_millit
        {
            get
            {
                return _Stofna_nýjan_v_innles_á_millit;
            }
            set
            {
                OnStofna_nýjan_v_innles_á_millitChanging(value);
                ReportPropertyChanging("Stofna_nýjan_v_innles_á_millit");
                _Stofna_nýjan_v_innles_á_millit = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Stofna_nýjan_v_innles_á_millit");
                OnStofna_nýjan_v_innles_á_millitChanged();
            }
        }
        private global::System.Byte _Stofna_nýjan_v_innles_á_millit;
        partial void OnStofna_nýjan_v_innles_á_millitChanging(global::System.Byte value);
        partial void OnStofna_nýjan_v_innles_á_millitChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Millitímar_teknir_eftir
        {
            get
            {
                return _Millitímar_teknir_eftir;
            }
            set
            {
                OnMillitímar_teknir_eftirChanging(value);
                ReportPropertyChanging("Millitímar_teknir_eftir");
                _Millitímar_teknir_eftir = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Millitímar_teknir_eftir");
                OnMillitímar_teknir_eftirChanged();
            }
        }
        private global::System.String _Millitímar_teknir_eftir;
        partial void OnMillitímar_teknir_eftirChanging(global::System.String value);
        partial void OnMillitímar_teknir_eftirChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte Nota_aðeins_ársbesta_við_röðun
        {
            get
            {
                return _Nota_aðeins_ársbesta_við_röðun;
            }
            set
            {
                OnNota_aðeins_ársbesta_við_röðunChanging(value);
                ReportPropertyChanging("Nota_aðeins_ársbesta_við_röðun");
                _Nota_aðeins_ársbesta_við_röðun = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Nota_aðeins_ársbesta_við_röðun");
                OnNota_aðeins_ársbesta_við_röðunChanged();
            }
        }
        private global::System.Byte _Nota_aðeins_ársbesta_við_röðun;
        partial void OnNota_aðeins_ársbesta_við_röðunChanging(global::System.Byte value);
        partial void OnNota_aðeins_ársbesta_við_röðunChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Tímabil_ársbesta_frá_mótsdags
        {
            get
            {
                return _Tímabil_ársbesta_frá_mótsdags;
            }
            set
            {
                OnTímabil_ársbesta_frá_mótsdagsChanging(value);
                ReportPropertyChanging("Tímabil_ársbesta_frá_mótsdags");
                _Tímabil_ársbesta_frá_mótsdags = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Tímabil_ársbesta_frá_mótsdags");
                OnTímabil_ársbesta_frá_mótsdagsChanged();
            }
        }
        private global::System.String _Tímabil_ársbesta_frá_mótsdags;
        partial void OnTímabil_ársbesta_frá_mótsdagsChanging(global::System.String value);
        partial void OnTímabil_ársbesta_frá_mótsdagsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte Reikna_IAAF_stig
        {
            get
            {
                return _Reikna_IAAF_stig;
            }
            set
            {
                OnReikna_IAAF_stigChanging(value);
                ReportPropertyChanging("Reikna_IAAF_stig");
                _Reikna_IAAF_stig = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Reikna_IAAF_stig");
                OnReikna_IAAF_stigChanged();
            }
        }
        private global::System.Byte _Reikna_IAAF_stig;
        partial void OnReikna_IAAF_stigChanging(global::System.Byte value);
        partial void OnReikna_IAAF_stigChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte Má_prenta_úrslit_frá_Scheduler
        {
            get
            {
                return _Má_prenta_úrslit_frá_Scheduler;
            }
            set
            {
                OnMá_prenta_úrslit_frá_SchedulerChanging(value);
                ReportPropertyChanging("Má_prenta_úrslit_frá_Scheduler");
                _Má_prenta_úrslit_frá_Scheduler = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Má_prenta_úrslit_frá_Scheduler");
                OnMá_prenta_úrslit_frá_SchedulerChanged();
            }
        }
        private global::System.Byte _Má_prenta_úrslit_frá_Scheduler;
        partial void OnMá_prenta_úrslit_frá_SchedulerChanging(global::System.Byte value);
        partial void OnMá_prenta_úrslit_frá_SchedulerChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte synamillitima4
        {
            get
            {
                return _synamillitima4;
            }
            set
            {
                Onsynamillitima4Changing(value);
                ReportPropertyChanging("synamillitima4");
                _synamillitima4 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("synamillitima4");
                Onsynamillitima4Changed();
            }
        }
        private global::System.Byte _synamillitima4;
        partial void Onsynamillitima4Changing(global::System.Byte value);
        partial void Onsynamillitima4Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte synamillitima5
        {
            get
            {
                return _synamillitima5;
            }
            set
            {
                Onsynamillitima5Changing(value);
                ReportPropertyChanging("synamillitima5");
                _synamillitima5 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("synamillitima5");
                Onsynamillitima5Changed();
            }
        }
        private global::System.Byte _synamillitima5;
        partial void Onsynamillitima5Changing(global::System.Byte value);
        partial void Onsynamillitima5Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte Með_rásnúmeri
        {
            get
            {
                return _Með_rásnúmeri;
            }
            set
            {
                OnMeð_rásnúmeriChanging(value);
                ReportPropertyChanging("Með_rásnúmeri");
                _Með_rásnúmeri = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Með_rásnúmeri");
                OnMeð_rásnúmeriChanged();
            }
        }
        private global::System.Byte _Með_rásnúmeri;
        partial void OnMeð_rásnúmeriChanging(global::System.Byte value);
        partial void OnMeð_rásnúmeriChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte Sleppa_í_afhendingu_rásnúmera
        {
            get
            {
                return _Sleppa_í_afhendingu_rásnúmera;
            }
            set
            {
                OnSleppa_í_afhendingu_rásnúmeraChanging(value);
                ReportPropertyChanging("Sleppa_í_afhendingu_rásnúmera");
                _Sleppa_í_afhendingu_rásnúmera = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Sleppa_í_afhendingu_rásnúmera");
                OnSleppa_í_afhendingu_rásnúmeraChanged();
            }
        }
        private global::System.Byte _Sleppa_í_afhendingu_rásnúmera;
        partial void OnSleppa_í_afhendingu_rásnúmeraChanging(global::System.Byte value);
        partial void OnSleppa_í_afhendingu_rásnúmeraChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal Skráningargj__yngri_en_18_ára
        {
            get
            {
                return _Skráningargj__yngri_en_18_ára;
            }
            set
            {
                OnSkráningargj__yngri_en_18_áraChanging(value);
                ReportPropertyChanging("Skráningargj__yngri_en_18_ára");
                _Skráningargj__yngri_en_18_ára = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Skráningargj__yngri_en_18_ára");
                OnSkráningargj__yngri_en_18_áraChanged();
            }
        }
        private global::System.Decimal _Skráningargj__yngri_en_18_ára;
        partial void OnSkráningargj__yngri_en_18_áraChanging(global::System.Decimal value);
        partial void OnSkráningargj__yngri_en_18_áraChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal Skráningargj__f_boðhl_y_18_ára
        {
            get
            {
                return _Skráningargj__f_boðhl_y_18_ára;
            }
            set
            {
                OnSkráningargj__f_boðhl_y_18_áraChanging(value);
                ReportPropertyChanging("Skráningargj__f_boðhl_y_18_ára");
                _Skráningargj__f_boðhl_y_18_ára = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Skráningargj__f_boðhl_y_18_ára");
                OnSkráningargj__f_boðhl_y_18_áraChanged();
            }
        }
        private global::System.Decimal _Skráningargj__f_boðhl_y_18_ára;
        partial void OnSkráningargj__f_boðhl_y_18_áraChanging(global::System.Decimal value);
        partial void OnSkráningargj__f_boðhl_y_18_áraChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 CompetitorsMinimumAge
        {
            get
            {
                return _CompetitorsMinimumAge;
            }
            set
            {
                OnCompetitorsMinimumAgeChanging(value);
                ReportPropertyChanging("CompetitorsMinimumAge");
                _CompetitorsMinimumAge = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CompetitorsMinimumAge");
                OnCompetitorsMinimumAgeChanged();
            }
        }
        private global::System.Int32 _CompetitorsMinimumAge;
        partial void OnCompetitorsMinimumAgeChanging(global::System.Int32 value);
        partial void OnCompetitorsMinimumAgeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Staða_móts
        {
            get
            {
                return _Staða_móts;
            }
            set
            {
                OnStaða_mótsChanging(value);
                ReportPropertyChanging("Staða_móts");
                _Staða_móts = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Staða_móts");
                OnStaða_mótsChanged();
            }
        }
        private global::System.Int32 _Staða_móts;
        partial void OnStaða_mótsChanging(global::System.Int32 value);
        partial void OnStaða_mótsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 EntryFeeType
        {
            get
            {
                return _EntryFeeType;
            }
            set
            {
                OnEntryFeeTypeChanging(value);
                ReportPropertyChanging("EntryFeeType");
                _EntryFeeType = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EntryFeeType");
                OnEntryFeeTypeChanged();
            }
        }
        private global::System.Int32 _EntryFeeType;
        partial void OnEntryFeeTypeChanging(global::System.Int32 value);
        partial void OnEntryFeeTypeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal EntryFeePrClub
        {
            get
            {
                return _EntryFeePrClub;
            }
            set
            {
                OnEntryFeePrClubChanging(value);
                ReportPropertyChanging("EntryFeePrClub");
                _EntryFeePrClub = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EntryFeePrClub");
                OnEntryFeePrClubChanged();
            }
        }
        private global::System.Decimal _EntryFeePrClub;
        partial void OnEntryFeePrClubChanging(global::System.Decimal value);
        partial void OnEntryFeePrClubChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 MaxAgeForFee1
        {
            get
            {
                return _MaxAgeForFee1;
            }
            set
            {
                OnMaxAgeForFee1Changing(value);
                ReportPropertyChanging("MaxAgeForFee1");
                _MaxAgeForFee1 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MaxAgeForFee1");
                OnMaxAgeForFee1Changed();
            }
        }
        private global::System.Int32 _MaxAgeForFee1;
        partial void OnMaxAgeForFee1Changing(global::System.Int32 value);
        partial void OnMaxAgeForFee1Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal EntryFeePrCompetitor1
        {
            get
            {
                return _EntryFeePrCompetitor1;
            }
            set
            {
                OnEntryFeePrCompetitor1Changing(value);
                ReportPropertyChanging("EntryFeePrCompetitor1");
                _EntryFeePrCompetitor1 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EntryFeePrCompetitor1");
                OnEntryFeePrCompetitor1Changed();
            }
        }
        private global::System.Decimal _EntryFeePrCompetitor1;
        partial void OnEntryFeePrCompetitor1Changing(global::System.Decimal value);
        partial void OnEntryFeePrCompetitor1Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 MaxAgeForFee2
        {
            get
            {
                return _MaxAgeForFee2;
            }
            set
            {
                OnMaxAgeForFee2Changing(value);
                ReportPropertyChanging("MaxAgeForFee2");
                _MaxAgeForFee2 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MaxAgeForFee2");
                OnMaxAgeForFee2Changed();
            }
        }
        private global::System.Int32 _MaxAgeForFee2;
        partial void OnMaxAgeForFee2Changing(global::System.Int32 value);
        partial void OnMaxAgeForFee2Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal EntryFeePrCompetitor2
        {
            get
            {
                return _EntryFeePrCompetitor2;
            }
            set
            {
                OnEntryFeePrCompetitor2Changing(value);
                ReportPropertyChanging("EntryFeePrCompetitor2");
                _EntryFeePrCompetitor2 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EntryFeePrCompetitor2");
                OnEntryFeePrCompetitor2Changed();
            }
        }
        private global::System.Decimal _EntryFeePrCompetitor2;
        partial void OnEntryFeePrCompetitor2Changing(global::System.Decimal value);
        partial void OnEntryFeePrCompetitor2Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 MaxAgeForFee3
        {
            get
            {
                return _MaxAgeForFee3;
            }
            set
            {
                OnMaxAgeForFee3Changing(value);
                ReportPropertyChanging("MaxAgeForFee3");
                _MaxAgeForFee3 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MaxAgeForFee3");
                OnMaxAgeForFee3Changed();
            }
        }
        private global::System.Int32 _MaxAgeForFee3;
        partial void OnMaxAgeForFee3Changing(global::System.Int32 value);
        partial void OnMaxAgeForFee3Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal EntryFeePrCompetitor3
        {
            get
            {
                return _EntryFeePrCompetitor3;
            }
            set
            {
                OnEntryFeePrCompetitor3Changing(value);
                ReportPropertyChanging("EntryFeePrCompetitor3");
                _EntryFeePrCompetitor3 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EntryFeePrCompetitor3");
                OnEntryFeePrCompetitor3Changed();
            }
        }
        private global::System.Decimal _EntryFeePrCompetitor3;
        partial void OnEntryFeePrCompetitor3Changing(global::System.Decimal value);
        partial void OnEntryFeePrCompetitor3Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal MaximumEntryFeePrCompetitor
        {
            get
            {
                return _MaximumEntryFeePrCompetitor;
            }
            set
            {
                OnMaximumEntryFeePrCompetitorChanging(value);
                ReportPropertyChanging("MaximumEntryFeePrCompetitor");
                _MaximumEntryFeePrCompetitor = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MaximumEntryFeePrCompetitor");
                OnMaximumEntryFeePrCompetitorChanged();
            }
        }
        private global::System.Decimal _MaximumEntryFeePrCompetitor;
        partial void OnMaximumEntryFeePrCompetitorChanging(global::System.Decimal value);
        partial void OnMaximumEntryFeePrCompetitorChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 DefaultTabOrderOnEntryForms
        {
            get
            {
                return _DefaultTabOrderOnEntryForms;
            }
            set
            {
                OnDefaultTabOrderOnEntryFormsChanging(value);
                ReportPropertyChanging("DefaultTabOrderOnEntryForms");
                _DefaultTabOrderOnEntryForms = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DefaultTabOrderOnEntryForms");
                OnDefaultTabOrderOnEntryFormsChanged();
            }
        }
        private global::System.Int32 _DefaultTabOrderOnEntryForms;
        partial void OnDefaultTabOrderOnEntryFormsChanging(global::System.Int32 value);
        partial void OnDefaultTabOrderOnEntryFormsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte DisplayColumnForPrizeCeremony
        {
            get
            {
                return _DisplayColumnForPrizeCeremony;
            }
            set
            {
                OnDisplayColumnForPrizeCeremonyChanging(value);
                ReportPropertyChanging("DisplayColumnForPrizeCeremony");
                _DisplayColumnForPrizeCeremony = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DisplayColumnForPrizeCeremony");
                OnDisplayColumnForPrizeCeremonyChanged();
            }
        }
        private global::System.Byte _DisplayColumnForPrizeCeremony;
        partial void OnDisplayColumnForPrizeCeremonyChanging(global::System.Byte value);
        partial void OnDisplayColumnForPrizeCeremonyChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Byte CompetitionFinalized
        {
            get
            {
                return _CompetitionFinalized;
            }
            set
            {
                OnCompetitionFinalizedChanging(value);
                ReportPropertyChanging("CompetitionFinalized");
                _CompetitionFinalized = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CompetitionFinalized");
                OnCompetitionFinalizedChanged();
            }
        }
        private global::System.Byte _CompetitionFinalized;
        partial void OnCompetitionFinalizedChanging(global::System.Byte value);
        partial void OnCompetitionFinalizedChanged();

        #endregion


    }
}
