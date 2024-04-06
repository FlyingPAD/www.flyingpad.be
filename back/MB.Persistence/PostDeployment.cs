using MB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace MB.Persistence
{
    public static class PostDeployment
    {
        public static void AddData(ModelBuilder modelBuilder)
        {
            // Default Artists

            var artistList = new List<Artist>
            {
                new() { EntityId = 1, BusinessId = Guid.NewGuid(), Name = "# Unknown Artist" },
                new() { EntityId = 2, BusinessId = Guid.NewGuid(), Name = "/ Unknown 2D Animator" },
                new() { EntityId = 3, BusinessId = Guid.NewGuid(), Name = "/ Unknown 2D Illustrator" },
                new() { EntityId = 4, BusinessId = Guid.NewGuid(), Name = "/ Unknown 3D Animator" },
                new() { EntityId = 5, BusinessId = Guid.NewGuid(), Name = "/ Unknown 3D Sculptor" },
                new() { EntityId = 6, BusinessId = Guid.NewGuid(), Name = "/ Unknown A.I. User" },
                new() { EntityId = 7, BusinessId = Guid.NewGuid(), Name = "/ Unknown Musician" },
                new() { EntityId = 8, BusinessId = Guid.NewGuid(), Name = "/ Unknown Photographer" },
                new() { EntityId = 9, BusinessId = Guid.NewGuid(), Name = "/ Unknown Sculptor" },
                new() { EntityId = 10, BusinessId = Guid.NewGuid(), Name = "/ Unknown Videast" },
                new() { EntityId = 11, BusinessId = Guid.NewGuid(), Name = "/ Unknown Writer" },
                new() { EntityId = 12, BusinessId = Guid.NewGuid(), Name = "Flying PAD" },
                new() { EntityId = 13, BusinessId = Guid.NewGuid(), Name = "Soën9048" },
                new() { EntityId = 14, BusinessId = Guid.NewGuid(), Name = "CohesivePanda" },
                new() { EntityId = 15, BusinessId = Guid.NewGuid(), Name = "Nobuo Uematsu" },
                new() { EntityId = 16, BusinessId = Guid.NewGuid(), Name = "Eichiro Oda" },
                new() { EntityId = 17, BusinessId = Guid.NewGuid(), Name = "Masashi Kishimoto" },
                new() { EntityId = 18, BusinessId = Guid.NewGuid(), Name = "Dali" },
                new() { EntityId = 19, BusinessId = Guid.NewGuid(), Name = "Yoko Shimomura" },
                new() { EntityId = 20, BusinessId = Guid.NewGuid(), Name = "Michael Jackson" },
                new() { EntityId = 21, BusinessId = Guid.NewGuid(), Name = "CG5" },
                new() { EntityId = 22, BusinessId = Guid.NewGuid(), Name = "TryHardNinja" },
                new() { EntityId = 23, BusinessId = Guid.NewGuid(), Name = "Jacob Collier" },
            };
            modelBuilder.Entity<Artist>().HasData(artistList);


            // Default Styles

            var styleList = new List<Style>
            {
                new() { EntityId = 1, BusinessId = Guid.NewGuid(), Name = "2D" },
                new() { EntityId = 2, BusinessId = Guid.NewGuid(), Name = "2D Animation" },
                new() { EntityId = 3, BusinessId = Guid.NewGuid(), Name = "3D" },
                new() { EntityId = 4, BusinessId = Guid.NewGuid(), Name = "3D Animation" },
                new() { EntityId = 5, BusinessId = Guid.NewGuid(), Name = "Architecture" },
                new() { EntityId = 6, BusinessId = Guid.NewGuid(), Name = "Writer" },
                new() { EntityId = 7, BusinessId = Guid.NewGuid(), Name = "Music" },
                new() { EntityId = 8, BusinessId = Guid.NewGuid(), Name = "Photo" },
                new() { EntityId = 9, BusinessId = Guid.NewGuid(), Name = "Video" },
                new() { EntityId = 10, BusinessId = Guid.NewGuid(), Name = "Video Games" },
            };
            modelBuilder.Entity<Style>().HasData(styleList);


            // Default Relations Artist / Style

            var relationsAS = new List<RelationArtistStyle>
            {
                new() { ArtistId = 12, StyleId = 7 },
                new() { ArtistId = 12, StyleId = 9 },
                new() { ArtistId = 13, StyleId = 9 },
                new() { ArtistId = 14, StyleId = 9 },
                new() { ArtistId = 15, StyleId = 9 },
                new() { ArtistId = 16, StyleId = 6 },
                new() { ArtistId = 17, StyleId = 6 },
                new() { ArtistId = 18, StyleId = 1 },
                new() { ArtistId = 19, StyleId = 2 },
                new() { ArtistId = 20, StyleId = 7 },
                new() { ArtistId = 21, StyleId = 7 },
                new() { ArtistId = 22, StyleId = 7 },
                new() { ArtistId = 23, StyleId = 7 },
            };
            modelBuilder.Entity<RelationArtistStyle>().HasData(relationsAS);


            // Default Franchises

            var franchiseList = new List<Franchise>
            {
                new() { EntityId = 1, BusinessId = Guid.NewGuid(), Name = "Flying PAD" },
                new() { EntityId = 2, BusinessId = Guid.NewGuid(), Name = "Street Fighter" },
            };
            modelBuilder.Entity<Franchise>().HasData(franchiseList);


            // Default Medias

            var mediasList = new List<Media>
            {
                new() { EntityId = 1, BusinessId = Guid.NewGuid(), Name = "# Super Franchise" },
                new() { EntityId = 2, BusinessId = Guid.NewGuid(), Name = "TV" },
                new() { EntityId = 3, BusinessId = Guid.NewGuid(), Name = "Radio" },
                new() { EntityId = 4, BusinessId = Guid.NewGuid(), Name = "YouTube" },
                new() { EntityId = 5, BusinessId = Guid.NewGuid(), Name = "Capcom" },
                new() { EntityId = 6, BusinessId = Guid.NewGuid(), Name = "Square-Enix" },
            };
            modelBuilder.Entity<Media>().HasData(mediasList);


            // Default Relations Franchise / Media

            var relationsFM = new List<RelationFranchiseMedia>
            {
                new() { FranchiseId = 1, MediaId = 1 },
                new() { FranchiseId = 2, MediaId = 1 },
            };
            modelBuilder.Entity<RelationFranchiseMedia>().HasData(relationsFM);


            // Default Relations Franchise / Model

            var relationsFModels = new List<RelationFranchiseModel>
            {
                new() { FranchiseId = 1, ModelId = 3 },
            };
            modelBuilder.Entity<RelationFranchiseModel>().HasData(relationsFModels);


            // Default Links

            var linkList = new List<Link>
            {
                new() { EntityId = 1, BusinessId = Guid.NewGuid(), Name = "KVR", Url = "https://www.kvraudio.com/" },
                new() { EntityId = 2, BusinessId = Guid.NewGuid(), Name = "MuseScore", Url = "https://musescore.com/" },
                new() { EntityId = 3, BusinessId = Guid.NewGuid(), Name = "Native Instruments", Url = "https://www.native-instruments.com" },
                new() { EntityId = 4, BusinessId = Guid.NewGuid(), Name = "Steinberg", Url = "https://www.steinberg.net/" },
                new() { EntityId = 5, BusinessId = Guid.NewGuid(), Name = "Clés pour l'harmonie", Url = "http://www.jo-anger-weller.com/102/cles-pour-lharmonie/" },
                new() { EntityId = 6, BusinessId = Guid.NewGuid(), Name = "Google | Metronome", Url = "https://www.google.com/search?q=metronome" },
                new() { EntityId = 7, BusinessId = Guid.NewGuid(), Name = "Google | Stopwatch", Url = "https://www.google.com/search?q=stopwatch" },
                new() { EntityId = 8, BusinessId = Guid.NewGuid(), Name = "Google | Timer", Url = "https://www.google.com/search?q=timer" },
                new() { EntityId = 9, BusinessId = Guid.NewGuid(), Name = "Mangold Project", Url = "https://www.youtube.com/@MangoldProject" },
                new() { EntityId = 10, BusinessId = Guid.NewGuid(), Name = "# YouTube", Url = "https://www.youtube.com" },
                new() { EntityId = 11, BusinessId = Guid.NewGuid(), Name = "Piano Jazz Concept", Url = "https://www.youtube.com/@Pianojazzconcept" },
                new() { EntityId = 12, BusinessId = Guid.NewGuid(), Name = "Rick Beato", Url = "https://www.youtube.com/@RickBeato" },
                new() { EntityId = 13, BusinessId = Guid.NewGuid(), Name = "Pianote", Url = "https://www.youtube.com/@PianoteOfficial" },
                new() { EntityId = 14, BusinessId = Guid.NewGuid(), Name = "TryHardNinja", Url = "https://www.youtube.com/@TryHardNinja" },
                new() { EntityId = 15, BusinessId = Guid.NewGuid(), Name = "Kyle Allen Music", Url = "https://www.youtube.com/@KyleAllenMusic" },
                new() { EntityId = 16, BusinessId = Guid.NewGuid(), Name = "Ableton", Url = "https://www.youtube.com/@Ableton" },
                new() { EntityId = 17, BusinessId = Guid.NewGuid(), Name = "La Machine à Mixer", Url = "https://www.youtube.com/@lamachineamixer" },
                new() { EntityId = 18, BusinessId = Guid.NewGuid(), Name = "Audiofanzine", Url = "https://www.youtube.com/@audiofanzine" },
                new() { EntityId = 19, BusinessId = Guid.NewGuid(), Name = "Cubase", Url = "https://www.youtube.com/@Cubase" },
                new() { EntityId = 20, BusinessId = Guid.NewGuid(), Name = "Ten Second Songs", Url = "https://www.youtube.com/@TenSecondSongs" },
                new() { EntityId = 21, BusinessId = Guid.NewGuid(), Name = "The Piano Guys", Url = "https://www.youtube.com/@thepianoguys" },
                new() { EntityId = 22, BusinessId = Guid.NewGuid(), Name = "CG5", Url = "https://www.youtube.com/@CG5" },
                new() { EntityId = 23, BusinessId = Guid.NewGuid(), Name = "Native Instruments", Url = "https://www.youtube.com/@NativeInstruments" },
                new() { EntityId = 24, BusinessId = Guid.NewGuid(), Name = "Ken Tamplin Vocal Academy", Url = "https://www.youtube.com/@kentamplin" },
                new() { EntityId = 25, BusinessId = Guid.NewGuid(), Name = "Pentatonix", Url = "https://www.youtube.com/@PTXofficial" },
                new() { EntityId = 26, BusinessId = Guid.NewGuid(), Name = "Recording Revolution", Url = "https://www.youtube.com/@recordingrevolution" },
                new() { EntityId = 27, BusinessId = Guid.NewGuid(), Name = "Jacob Collier", Url = "https://www.youtube.com/@jacobcollier" },
                new() { EntityId = 28, BusinessId = Guid.NewGuid(), Name = "Orchestration Online", Url = "https://www.youtube.com/@OrchestrationOnline" },
                new() { EntityId = 29, BusinessId = Guid.NewGuid(), Name = "Nuendo", Url = "https://www.youtube.com/@Nuendo" },
                new() { EntityId = 30, BusinessId = Guid.NewGuid(), Name = "reFX", Url = "https://www.youtube.com/@reFXaudio" },
                new() { EntityId = 31, BusinessId = Guid.NewGuid(), Name = "Steinberg", Url = "https://www.youtube.com/@steinberg" },
            };
            modelBuilder.Entity<Link>().HasData(linkList);


            // Default Link Categories

            var categoriesList = new List<LinkCategory>
            {
                new() { EntityId = 1, BusinessId = Guid.NewGuid(), Name = "Audio" },
                new() { EntityId = 2, BusinessId = Guid.NewGuid(), Name = "Audio | Mix & Master" },
                new() { EntityId = 3, BusinessId = Guid.NewGuid(), Name = "Audio | Sound Design" },
                new() { EntityId = 4, BusinessId = Guid.NewGuid(), Name = "Books" },
                new() { EntityId = 5, BusinessId = Guid.NewGuid(), Name = "Books | Harmony" },
                new() { EntityId = 6, BusinessId = Guid.NewGuid(), Name = "Software" },
                new() { EntityId = 7, BusinessId = Guid.NewGuid(), Name = "Software | D.A.W." },
                new() { EntityId = 8, BusinessId = Guid.NewGuid(), Name = "Software | V.S.T." },
                new() { EntityId = 9, BusinessId = Guid.NewGuid(), Name = "Software | Music Notation" },
                new() { EntityId = 10, BusinessId = Guid.NewGuid(), Name = "Tools" },
                new() { EntityId = 11, BusinessId = Guid.NewGuid(), Name = "Tools | Global" },
                new() { EntityId = 12, BusinessId = Guid.NewGuid(), Name = "YouTube" },
                new() { EntityId = 13, BusinessId = Guid.NewGuid(), Name = "YouTube | Artists" },
                new() { EntityId = 14, BusinessId = Guid.NewGuid(), Name = "YouTube | Audio" },
                new() { EntityId = 15, BusinessId = Guid.NewGuid(), Name = "YouTube | Piano & Keys" },
            };
            modelBuilder.Entity<LinkCategory>().HasData(categoriesList);


            // Default Relations Link Categories

            var relationsLC = new List<RelationLinkCategory>
            {
                new() { LinkId = 1, LinkCategoryId = 1 },
                new() { LinkId = 1, LinkCategoryId = 8 },
                new() { LinkId = 2, LinkCategoryId = 6 },
                new() { LinkId = 2, LinkCategoryId = 9 },
                new() { LinkId = 3, LinkCategoryId = 6 },
                new() { LinkId = 3, LinkCategoryId = 8 },
                new() { LinkId = 4, LinkCategoryId = 6 },
                new() { LinkId = 5, LinkCategoryId = 4 },
                new() { LinkId = 5, LinkCategoryId = 5 },
                new() { LinkId = 6, LinkCategoryId = 10 },
                new() { LinkId = 7, LinkCategoryId = 10 },
                new() { LinkId = 8, LinkCategoryId = 10 },
                new() { LinkId = 9, LinkCategoryId = 12 },
                new() { LinkId = 9, LinkCategoryId = 15 },
                new() { LinkId = 10, LinkCategoryId = 12 },
                new() { LinkId = 11, LinkCategoryId = 12 },
                new() { LinkId = 11, LinkCategoryId = 15 },
                new() { LinkId = 12, LinkCategoryId = 12 },
                new() { LinkId = 13, LinkCategoryId = 12 },
                new() { LinkId = 14, LinkCategoryId = 12 },
                new() { LinkId = 14, LinkCategoryId = 13 },
                new() { LinkId = 15, LinkCategoryId = 12 },
                new() { LinkId = 16, LinkCategoryId = 12 },
                new() { LinkId = 17, LinkCategoryId = 12 },
                new() { LinkId = 18, LinkCategoryId = 12 },
                new() { LinkId = 19, LinkCategoryId = 12 },
                new() { LinkId = 20, LinkCategoryId = 12 },
                new() { LinkId = 21, LinkCategoryId = 12 },
                new() { LinkId = 22, LinkCategoryId = 12 },
                new() { LinkId = 23, LinkCategoryId = 12 },
                new() { LinkId = 24, LinkCategoryId = 12 },
                new() { LinkId = 25, LinkCategoryId = 12 },
                new() { LinkId = 26, LinkCategoryId = 1 },
                new() { LinkId = 26, LinkCategoryId = 2 },
                new() { LinkId = 26, LinkCategoryId = 12 },
                new() { LinkId = 26, LinkCategoryId = 14 },
                new() { LinkId = 27, LinkCategoryId = 12 },
                new() { LinkId = 27, LinkCategoryId = 13 },
                new() { LinkId = 28, LinkCategoryId = 12 },
                new() { LinkId = 29, LinkCategoryId = 12 },
                new() { LinkId = 30, LinkCategoryId = 12 },
                new() { LinkId = 31, LinkCategoryId = 12 },
            };
            modelBuilder.Entity<RelationLinkCategory>().HasData(relationsLC);


            // Default Models

            var modelList = new List<Model>
            {
                new() { EntityId = 1, BusinessId = Guid.NewGuid(), FirstName = "", LastName = "", Pseudonym = "# Unknown Model" },
                new() { EntityId = 2, BusinessId = Guid.NewGuid(), FirstName = "", LastName = "", Pseudonym = "/ Unrelated Model" },
                new() { EntityId = 3, BusinessId = Guid.NewGuid(), FirstName = "Tony", LastName = "Van Langenhove", Pseudonym = "Flying PAD", Gender = "M" },
            };
            modelBuilder.Entity<Model>().HasData(modelList);


            // Default Moods

            var imagesList = new List<Image>
            {
                new() { EntityId = 1, BusinessId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), Type = 1, Extension = "jpg", Size = 61206, Width = 359, Height = 510, Name = " Major Key Notes", Description = "In Chords Chart"  },
                new() { EntityId = 2, BusinessId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), Type = 1, Extension = "jpg", Size = 136462, Width = 700, Height = 940, Name = "Major Diatonic Scales", Description = "7 Notes, 7 Positions"  },
                new() { EntityId = 3, BusinessId = new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), Type = 1, Extension = "jpg", Size = 562138, Width = 868, Height = 1361, Name = "Piano Chords", Description = "Fundamental Positions"  },
                new() { EntityId = 4, BusinessId = new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), Type = 1, Extension = "jpg", Size = 74358, Width = 250, Height = 524, Name = "Pentatonic Scales", Description = "5 Notes, 5 Positions"  },
                new() { EntityId = 5, BusinessId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), Type = 1, Extension = "png", Size = 56324, Width = 556, Height = 844, Name = "Intervals", Description = "Color Measure"  },
                new() { EntityId = 6, BusinessId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"), Type = 1, Extension = "png", Size = 8992, Width = 400, Height = 255, Name = "Time Measure", Description = "Absolute Basics"  },
                new() { EntityId = 7, BusinessId = new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc1"), Type = 1, Extension = "webp", Size = 30964, Width = 600, Height = 226, Name = "Harmonics", Description = "Natural Order"  },
                new() { EntityId = 8, BusinessId = new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1"), Type = 1, Extension = "png", Size = 99994, Width = 512, Height = 705, Name = "Guitar Vocabulary", Description = "Communication is important"  },
                new() { EntityId = 9, BusinessId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2"), Type = 1, Extension = "jpg", Size = 204898, Width = 1199, Height = 1317, Name = "Piano Chords", Description = "Diatonic Chords in C Major"  },
                new() { EntityId = 10, BusinessId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), Type = 1, Extension = "jpg", Size = 91482, Width = 695, Height = 900, Name = "Piano Scales", Description = "Mmm... You can tell, right ?" },
                new() { EntityId = 11, BusinessId = new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc2"), Type = 1, Extension = "gif", Size = 62391, Width = 1026, Height = 709, Name = "Tessitures", Description = "Overview"  },
                new() { EntityId = 12, BusinessId = new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd2"), Type = 1, Extension = "png", Size = 663017, Width = 950, Height = 950, Name = "Chord Wheel", Description = "Circle of Life"  },
                new() { EntityId = 13, BusinessId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3"), Type = 1, Extension = "jpeg", Size = 45254, Width = 640, Height = 480, Name = "The Mix is Almost Perfect", Description = " ... "  },
                new() { EntityId = 14, BusinessId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3"), Type = 1, Extension = "jpg", Size = 167969, Width = 552, Height = 690, Name = "Guitar Progressions", Description = "Basic Chords / Different Keys"  },
                new() { EntityId = 15, BusinessId = new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc3"), Type = 1, Extension = "jpeg", Size = 205144, Width = 720, Height = 960, Name = "Vous le voulez comment votre projet ?", Description = "Les 3, c'est NON !"  },
                new() { EntityId = 16, BusinessId = new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd3"), Type = 1, Extension = "jpg", Size = 24030, Width = 350, Height = 233, Name = "Fingers Numerotation", Description = "1, 2, 3, 4, 5" },
                new() { EntityId = 17, BusinessId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa4"), Type = 1, Extension = "jpg", Size = 87596, Width = 1680, Height = 368, Name = "Roland FP-30", Description = "My actual Keyboard"  },
                new() { EntityId = 18, BusinessId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb4"), Type = 1, Extension = "jpg", Size = 221030, Width = 1080, Height = 1109, Name = "Chord Formula's", Description = "How to build a chord" },
                new() { EntityId = 19, BusinessId = new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc4"), Type = 1, Extension = "webp", Size = 21922, Width = 640, Height = 530, Name = "Time Values", Description = "Valeurs de Temps"  },
                new() { EntityId = 20, BusinessId = new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd4"), Type = 1, Extension = "jpg", Size = 57447, Width = 640, Height = 909, Name = "Guitar Chords ( B )", Description = "Fundamental Positions"  },
                new() { EntityId = 21, BusinessId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa5"), Type = 1, Extension = "jpg", Size = 111187, Width = 1199, Height = 1552, Name = "Modes starting in C", Description = "Primary Modes"  },
                new() { EntityId = 22, BusinessId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb5"), Type = 1, Extension = "jpg", Size = 633229, Width = 1200, Height = 1913, Name = "Guitar Chords", Description = "Good luck finding the good one ..." },
                new() { EntityId = 23, BusinessId = new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc5"), Type = 1, Extension = "png", Size = 69313, Width = 692, Height = 971, Name = "Intervalles", Description = "Une approche parmis tant d'autres"  },
            };
            modelBuilder.Entity<Image>().HasData(imagesList);

            var videoList = new List<Video>
            {
                new() { EntityId = 55, BusinessId = new Guid("cccccccc-cccc-cccc-cccc-cccccccccc55"), Type = 2, Extension = "mp4", Size = 5091239, Width = 640, Height = 360, Duration = 64, Name = "BATIM - Build our Machine", Description = " Bendy & The Ink Machine " },
            };
            modelBuilder.Entity<Video>().HasData(videoList);

            var videoYouTubeList = new List<VideoYouTube>
            {
                new() { EntityId = 85, BusinessId = new Guid("cccccccc-cccc-cccc-cccc-cccccccccc85"), Type = 4, Extension = "", Url = "WWUxrTdjqg0" ,Name = "Mario Bros 3 Cover", Description = "..." },
            };
            modelBuilder.Entity<VideoYouTube>().HasData(videoYouTubeList);


            // Default Relations Mood / Artist

            var relationsMA = new List<RelationMoodArtist>
            {
                new() { MoodId = 1, ArtistId = 1 },
                new() { MoodId = 2, ArtistId = 1 },
                new() { MoodId = 3, ArtistId = 1 },
                new() { MoodId = 4, ArtistId = 1 },
                new() { MoodId = 5, ArtistId = 1 },
                new() { MoodId = 6, ArtistId = 1 },
                new() { MoodId = 7, ArtistId = 1 },
                new() { MoodId = 8, ArtistId = 1 },
                new() { MoodId = 9, ArtistId = 1 },
                new() { MoodId = 10, ArtistId = 1 },
                new() { MoodId = 11, ArtistId = 1 },
                new() { MoodId = 12, ArtistId = 12 },
                new() { MoodId = 13, ArtistId = 1 },
                new() { MoodId = 14, ArtistId = 1 },
                new() { MoodId = 15, ArtistId = 1 },
                new() { MoodId = 16, ArtistId = 1 },
                new() { MoodId = 17, ArtistId = 1 },
                new() { MoodId = 18, ArtistId = 1 },
                new() { MoodId = 19, ArtistId = 1 },
                new() { MoodId = 20, ArtistId = 1 },
                new() { MoodId = 21, ArtistId = 1 },
                new() { MoodId = 22, ArtistId = 1 },
                new() { MoodId = 23, ArtistId = 1 },
                new() { MoodId = 55, ArtistId = 1 },
                new() { MoodId = 85, ArtistId = 1 },
            };
            modelBuilder.Entity<RelationMoodArtist>().HasData(relationsMA);


            // Default Relations Mood / Model

            var relationsMM = new List<RelationMoodModel>
            {
                new() { MoodId = 1, ModelId = 1 },
                new() { MoodId = 2, ModelId = 1 },
                new() { MoodId = 3, ModelId = 1 },
                new() { MoodId = 4, ModelId = 1 },
                new() { MoodId = 5, ModelId = 1 },
                new() { MoodId = 6, ModelId = 1 },
                new() { MoodId = 7, ModelId = 1 },
                new() { MoodId = 8, ModelId = 1 },
                new() { MoodId = 9, ModelId = 1 },
                new() { MoodId = 10, ModelId = 1 },
                new() { MoodId = 11, ModelId = 1 },
                new() { MoodId = 12, ModelId = 3 },
                new() { MoodId = 13, ModelId = 1 },
                new() { MoodId = 14, ModelId = 1 },
                new() { MoodId = 15, ModelId = 1 },
                new() { MoodId = 16, ModelId = 1 },
                new() { MoodId = 17, ModelId = 1 },
                new() { MoodId = 18, ModelId = 1 },
                new() { MoodId = 19, ModelId = 1 },
                new() { MoodId = 20, ModelId = 1 },
                new() { MoodId = 21, ModelId = 1 },
                new() { MoodId = 22, ModelId = 1 },
                new() { MoodId = 23, ModelId = 1 },
                new() { MoodId = 55, ModelId = 1 },
                new() { MoodId = 85, ModelId = 1 },
            };
            modelBuilder.Entity<RelationMoodModel>().HasData(relationsMM);


            // Default Relations Mood / Tag

            var relationsMT = new List<RelationMoodTag>
            {
                new() { MoodId = 1, TagId = 1 },
                new() { MoodId = 1, TagId = 4 },
                new() { MoodId = 1, TagId = 10 },
                new() { MoodId = 1, TagId = 17 },
                new() { MoodId = 1, TagId = 34 },

                new() { MoodId = 2, TagId = 1 },
                new() { MoodId = 2, TagId = 4 },
                new() { MoodId = 2, TagId = 10 },
                new() { MoodId = 2, TagId = 17 },
                new() { MoodId = 2, TagId = 34 },
                new() { MoodId = 2, TagId = 59 },

                new() { MoodId = 3, TagId = 1 },
                new() { MoodId = 3, TagId = 4 },
                new() { MoodId = 3, TagId = 10 },
                new() { MoodId = 3, TagId = 17 },
                new() { MoodId = 3, TagId = 34 },
                new() { MoodId = 3, TagId = 43 },

                new() { MoodId = 4, TagId = 1 },
                new() { MoodId = 4, TagId = 4 },
                new() { MoodId = 4, TagId = 10 },
                new() { MoodId = 4, TagId = 17 },
                new() { MoodId = 4, TagId = 34 },
                new() { MoodId = 4, TagId = 59 },

                new() { MoodId = 5, TagId = 1 },
                new() { MoodId = 5, TagId = 4 },
                new() { MoodId = 5, TagId = 11 },
                new() { MoodId = 5, TagId = 17 },
                new() { MoodId = 5, TagId = 34 },

                new() { MoodId = 6, TagId = 1 },
                new() { MoodId = 6, TagId = 4 },
                new() { MoodId = 6, TagId = 11 },
                new() { MoodId = 6, TagId = 15 },
                new() { MoodId = 6, TagId = 34 },

                new() { MoodId = 7, TagId = 1 },
                new() { MoodId = 7, TagId = 4 },
                new() { MoodId = 7, TagId = 12 },
                new() { MoodId = 7, TagId = 15 },
                new() { MoodId = 7, TagId = 34 },

                new() { MoodId = 8, TagId = 1 },
                new() { MoodId = 8, TagId = 4 },
                new() { MoodId = 8, TagId = 11 },
                new() { MoodId = 8, TagId = 17 },
                new() { MoodId = 8, TagId = 34 },
                new() { MoodId = 8, TagId = 59 },

                new() { MoodId = 9, TagId = 1 },
                new() { MoodId = 9, TagId = 4 },
                new() { MoodId = 9, TagId = 10 },
                new() { MoodId = 9, TagId = 17 },
                new() { MoodId = 9, TagId = 34 },
                new() { MoodId = 9, TagId = 43 },

                new() { MoodId = 10, TagId = 1 },
                new() { MoodId = 10, TagId = 4 },
                new() { MoodId = 10, TagId = 10 },
                new() { MoodId = 10, TagId = 17 },
                new() { MoodId = 10, TagId = 34 },
                new() { MoodId = 10, TagId = 43 },

                new() { MoodId = 11, TagId = 1 },
                new() { MoodId = 11, TagId = 4 },
                new() { MoodId = 11, TagId = 8 },
                new() { MoodId = 11, TagId = 15 },
                new() { MoodId = 11, TagId = 34 },

                new() { MoodId = 12, TagId = 1 },
                new() { MoodId = 12, TagId = 4 },
                new() { MoodId = 12, TagId = 11 },
                new() { MoodId = 12, TagId = 19 },
                new() { MoodId = 12, TagId = 34 },

                new() { MoodId = 13, TagId = 1 },
                new() { MoodId = 13, TagId = 4 },
                new() { MoodId = 13, TagId = 9 },
                new() { MoodId = 13, TagId = 15 },
                new() { MoodId = 13, TagId = 58 },

                new() { MoodId = 14, TagId = 1 },
                new() { MoodId = 14, TagId = 4 },
                new() { MoodId = 14, TagId = 10 },
                new() { MoodId = 14, TagId = 17 },
                new() { MoodId = 14, TagId = 59 },

                new() { MoodId = 15, TagId = 1 },
                new() { MoodId = 15, TagId = 4 },
                new() { MoodId = 15, TagId = 9 },
                new() { MoodId = 15, TagId = 17 },

                new() { MoodId = 16, TagId = 1 },
                new() { MoodId = 16, TagId = 4 },
                new() { MoodId = 16, TagId = 10 },
                new() { MoodId = 16, TagId = 15 },
                new() { MoodId = 16, TagId = 43 },

                new() { MoodId = 17, TagId = 1 },
                new() { MoodId = 17, TagId = 4 },
                new() { MoodId = 17, TagId = 10 },
                new() { MoodId = 17, TagId = 15 },
                new() { MoodId = 17, TagId = 43 },

                new() { MoodId = 18, TagId = 1 },
                new() { MoodId = 18, TagId = 4 },
                new() { MoodId = 18, TagId = 10 },
                new() { MoodId = 18, TagId = 17 },

                new() { MoodId = 19, TagId = 1 },
                new() { MoodId = 19, TagId = 4 },
                new() { MoodId = 19, TagId = 12 },
                new() { MoodId = 19, TagId = 15 },

                new() { MoodId = 20, TagId = 1 },
                new() { MoodId = 20, TagId = 4 },
                new() { MoodId = 20, TagId = 10 },
                new() { MoodId = 20, TagId = 17 },
                new() { MoodId = 20, TagId = 59 },

                new() { MoodId = 21, TagId = 1 },
                new() { MoodId = 21, TagId = 4 },
                new() { MoodId = 21, TagId = 10 },
                new() { MoodId = 21, TagId = 15 },

                new() { MoodId = 22, TagId = 1 },
                new() { MoodId = 22, TagId = 4 },
                new() { MoodId = 22, TagId = 10 },
                new() { MoodId = 22, TagId = 17 },
                new() { MoodId = 22, TagId = 59 },

                new() { MoodId = 23, TagId = 1 },
                new() { MoodId = 23, TagId = 4 },
                new() { MoodId = 23, TagId = 11 },
                new() { MoodId = 23, TagId = 17 },

                new() { MoodId = 55, TagId = 1 },
                new() { MoodId = 55, TagId = 15 },
                new() { MoodId = 55, TagId = 16 },
                new() { MoodId = 55, TagId = 43 },

                new() { MoodId = 85, TagId = 1 },
                new() { MoodId = 85, TagId = 15 },
                new() { MoodId = 85, TagId = 16 },
                new() { MoodId = 85, TagId = 43 },
            };
            modelBuilder.Entity<RelationMoodTag>().HasData(relationsMT);


            // Default Tags

            var tagList = new List<Tag>
            {
                new() { EntityId = 1,  BusinessId = Guid.NewGuid(), Name = "# All Files", TagCategoryId = 1 },
                new() { EntityId = 2,  BusinessId = Guid.NewGuid(), Name = "Audio", TagCategoryId = 2 },
                new() { EntityId = 3,  BusinessId = Guid.NewGuid(), Name = "Document", TagCategoryId = 2 },
                new() { EntityId = 4,  BusinessId = Guid.NewGuid(), Name = "Image", TagCategoryId = 2 },
                new() { EntityId = 5,  BusinessId = Guid.NewGuid(), Name = "Video", TagCategoryId = 2 },
                new() { EntityId = 6,  BusinessId = Guid.NewGuid(), Name = "*.txt", TagCategoryId = 3 },
                new() { EntityId = 7,  BusinessId = Guid.NewGuid(), Name = "*.bmp", TagCategoryId = 4 },
                new() { EntityId = 8,  BusinessId = Guid.NewGuid(), Name = "*.gif", TagCategoryId = 4 },
                new() { EntityId = 9,  BusinessId = Guid.NewGuid(), Name = "*.jpeg", TagCategoryId = 4 },
                new() { EntityId = 10, BusinessId = Guid.NewGuid(), Name = "*.jpg", TagCategoryId = 4 },
                new() { EntityId = 11, BusinessId = Guid.NewGuid(), Name = "*.png", TagCategoryId = 4 },
                new() { EntityId = 12, BusinessId = Guid.NewGuid(), Name = "*.webp", TagCategoryId = 4 },
                new() { EntityId = 13, BusinessId = Guid.NewGuid(), Name = "*.mp4", TagCategoryId = 5 },
                new() { EntityId = 14, BusinessId = Guid.NewGuid(), Name = "*.webm", TagCategoryId = 5 },
                new() { EntityId = 15, BusinessId = Guid.NewGuid(), Name = "Landscape", TagCategoryId = 6 },
                new() { EntityId = 16, BusinessId = Guid.NewGuid(), Name = "Landscape ( 16:9 )", TagCategoryId = 6 },
                new() { EntityId = 17, BusinessId = Guid.NewGuid(), Name = "Portrait", TagCategoryId = 6 },
                new() { EntityId = 18, BusinessId = Guid.NewGuid(), Name = "Portrait ( 16:9 )", TagCategoryId = 6 },
                new() { EntityId = 19, BusinessId = Guid.NewGuid(), Name = "Square", TagCategoryId = 6 },
                new() { EntityId = 20, BusinessId = Guid.NewGuid(), Name = "2D", TagCategoryId = 7 },
                new() { EntityId = 21, BusinessId = Guid.NewGuid(), Name = "2D | Anim", TagCategoryId = 7 },
                new() { EntityId = 22, BusinessId = Guid.NewGuid(), Name = "3D", TagCategoryId = 7 },
                new() { EntityId = 23, BusinessId = Guid.NewGuid(), Name = "3D | Anim", TagCategoryId = 7 },
                new() { EntityId = 24, BusinessId = Guid.NewGuid(), Name = "Photo", TagCategoryId = 7 },
                new() { EntityId = 25, BusinessId = Guid.NewGuid(), Name = "Photo | Anim", TagCategoryId = 7 },
                new() { EntityId = 26, BusinessId = Guid.NewGuid(), Name = "E.D.M.", TagCategoryId = 8 },
                new() { EntityId = 27, BusinessId = Guid.NewGuid(), Name = "Jazz", TagCategoryId = 8 },
                new() { EntityId = 28, BusinessId = Guid.NewGuid(), Name = "Metal", TagCategoryId = 8 },
                new() { EntityId = 29, BusinessId = Guid.NewGuid(), Name = "Orchestral", TagCategoryId = 8 },
                new() { EntityId = 30, BusinessId = Guid.NewGuid(), Name = "Pop Music", TagCategoryId = 8 },
                new() { EntityId = 31, BusinessId = Guid.NewGuid(), Name = "Rap", TagCategoryId = 8 },
                new() { EntityId = 32, BusinessId = Guid.NewGuid(), Name = "Rock", TagCategoryId = 8 },
                new() { EntityId = 33, BusinessId = Guid.NewGuid(), Name = "Traditional", TagCategoryId = 8 },
                new() { EntityId = 34, BusinessId = Guid.NewGuid(), Name = "# Music Theory", TagCategoryId = 9 },
                new() { EntityId = 35, BusinessId = Guid.NewGuid(), Name = "# Harmony", TagCategoryId = 9 },
                new() { EntityId = 36, BusinessId = Guid.NewGuid(), Name = "Chords", TagCategoryId = 9 },
                new() { EntityId = 37, BusinessId = Guid.NewGuid(), Name = "Harmonics", TagCategoryId = 9 },
                new() { EntityId = 38, BusinessId = Guid.NewGuid(), Name = "Intervals", TagCategoryId = 9 },
                new() { EntityId = 39, BusinessId = Guid.NewGuid(), Name = "Rythm", TagCategoryId = 9 },
                new() { EntityId = 40, BusinessId = Guid.NewGuid(), Name = "Scales", TagCategoryId = 9 },
                new() { EntityId = 41, BusinessId = Guid.NewGuid(), Name = "Modes", TagCategoryId = 9 },
                new() { EntityId = 42, BusinessId = Guid.NewGuid(), Name = "# Keys", TagCategoryId = 10 },
                new() { EntityId = 43, BusinessId = Guid.NewGuid(), Name = "Piano", TagCategoryId = 10 },
                new() { EntityId = 44, BusinessId = Guid.NewGuid(), Name = "# Brass", TagCategoryId = 11 },
                new() { EntityId = 45, BusinessId = Guid.NewGuid(), Name = "Trombone", TagCategoryId = 11 },
                new() { EntityId = 46, BusinessId = Guid.NewGuid(), Name = "# Strings", TagCategoryId = 12 },
                new() { EntityId = 47, BusinessId = Guid.NewGuid(), Name = "Violin", TagCategoryId = 12 },
                new() { EntityId = 48, BusinessId = Guid.NewGuid(), Name = "# Percussions", TagCategoryId = 13 },
                new() { EntityId = 49, BusinessId = Guid.NewGuid(), Name = "Drums", TagCategoryId = 13 },
                new() { EntityId = 50, BusinessId = Guid.NewGuid(), Name = "# Woodwinds", TagCategoryId = 14 },
                new() { EntityId = 51, BusinessId = Guid.NewGuid(), Name = "Clarinet", TagCategoryId = 14 },
                new() { EntityId = 52, BusinessId = Guid.NewGuid(), Name = "# Audio", TagCategoryId = 15 },
                new() { EntityId = 53, BusinessId = Guid.NewGuid(), Name = "Mixing", TagCategoryId = 15 },
                new() { EntityId = 54, BusinessId = Guid.NewGuid(), Name = "Mastering", TagCategoryId = 15 },
                new() { EntityId = 55, BusinessId = Guid.NewGuid(), Name = "Recording", TagCategoryId = 15 },
                new() { EntityId = 56, BusinessId = Guid.NewGuid(), Name = "Production", TagCategoryId = 15 },
                new() { EntityId = 57, BusinessId = Guid.NewGuid(), Name = "Sound Design", TagCategoryId = 15 },
                new() { EntityId = 58, BusinessId = Guid.NewGuid(), Name = "Memes", TagCategoryId = 16 },
                new() { EntityId = 59, BusinessId = Guid.NewGuid(), Name = "# Guitar", TagCategoryId = 17 },
            };
            modelBuilder.Entity<Tag>().HasData(tagList);


            // Default Tag Categories

            var tagCategoriesList = new List<TagCategory>
            {
                new() { EntityId = 1,  BusinessId = Guid.NewGuid(), Name = "#" },
                new() { EntityId = 2,  BusinessId = Guid.NewGuid(), Name = "# File" },
                new() { EntityId = 3,  BusinessId = Guid.NewGuid(), Name = "# File ext. | Doc." },
                new() { EntityId = 4,  BusinessId = Guid.NewGuid(), Name = "# File ext. | Image" },
                new() { EntityId = 5,  BusinessId = Guid.NewGuid(), Name = "# File ext. | Video" },
                new() { EntityId = 6,  BusinessId = Guid.NewGuid(), Name = "# File Format" },
                new() { EntityId = 7,  BusinessId = Guid.NewGuid(), Name = "# File Render" },
                new() { EntityId = 8,  BusinessId = Guid.NewGuid(), Name = "Music Genre" },
                new() { EntityId = 9,  BusinessId = Guid.NewGuid(), Name = "Music Theory" },
                new() { EntityId = 10, BusinessId = Guid.NewGuid(), Name = "Keys" },
                new() { EntityId = 11, BusinessId = Guid.NewGuid(), Name = "Brass" },
                new() { EntityId = 12, BusinessId = Guid.NewGuid(), Name = "Strings" },
                new() { EntityId = 13, BusinessId = Guid.NewGuid(), Name = "Percussions" },
                new() { EntityId = 14, BusinessId = Guid.NewGuid(), Name = "Woodwinds" },
                new() { EntityId = 15, BusinessId = Guid.NewGuid(), Name = "Audio" },
                new() { EntityId = 16, BusinessId = Guid.NewGuid(), Name = "Fun" },
                new() { EntityId = 17, BusinessId = Guid.NewGuid(), Name = "Guitar" },
            };
            modelBuilder.Entity<TagCategory>().HasData(tagCategoriesList);


            // Default Task Categories

            var taskCategories = new List<TaskCategory>
            {
                new() { EntityId = 1, BusinessId = Guid.NewGuid(), Name = "PAD Mobile" },
                new() { EntityId = 2, BusinessId = Guid.NewGuid(), Name = "PAD Cave"},
                new() { EntityId = 3, BusinessId = Guid.NewGuid(), Name = "PAD Kids" },
                new() { EntityId = 4, BusinessId = Guid.NewGuid(), Name = "Shopping" },
                new() { EntityId = 5, BusinessId = Guid.NewGuid(), Name = "Work" }
            };
            modelBuilder.Entity<TaskCategory>().HasData(taskCategories);


            // Default Tasks

            var tasks = new List<Domain.Entities.Task>
            {
                new() { EntityId = 1, BusinessId = Guid.NewGuid(), Name = "Check Mails", TaskCategoryId = 5 }
            };
            modelBuilder.Entity<Domain.Entities.Task>().HasData(tasks);


            // Default Users

            var userList = new List<User>();
            int entityId = 1;

            var usersToCreate = new List<(string FirstName, string LastName, string Email, DateTime Birthdate, string Password, int Role)>
            {
                ("Tony", "Van Langenhove", "tonyvan@live.fr", new DateTime(1982, 7, 15), "Test1234=", 2),
                ("Floppy", "Disk", "floppy@gmail.com", new DateTime(1975, 1, 1), "Test1234=", 1),
                ("Vincent", "Megag", "vincent.megag@gmail.com", new DateTime(1980, 1, 1), "Test1234=", 2),
            };

            foreach (var (FirstName, LastName, Email, Birthdate, Password, Role) in usersToCreate)
            {
                CreatePasswordHash(Password, out byte[] passwordHash, out byte[] passwordSalt);
                userList.Add(new User
                {
                    EntityId = entityId++,
                    BusinessId = Guid.NewGuid(),
                    FirstName = FirstName,
                    LastName = LastName,
                    Email = Email,
                    Birthdate = Birthdate,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    Role = Role
                });
            }
            modelBuilder.Entity<User>().HasData(userList);

            static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
            {
                using var hmac = new HMACSHA512();
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}