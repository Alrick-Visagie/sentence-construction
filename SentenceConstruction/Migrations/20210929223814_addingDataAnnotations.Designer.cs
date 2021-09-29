﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SentenceConstruction.Repository;

namespace SentenceConstruction.Migrations
{
    [DbContext(typeof(SentenceConstructionDbContext))]
    [Migration("20210929223814_addingDataAnnotations")]
    partial class addingDataAnnotations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SentenceConstruction.Repository.Models.Sentences", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Sentence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sentences");

                    b.HasData(
                        new
                        {
                            ID = "8a8f3ab2-9907-4771-8df6-a0227e813970",
                            Sentence = "Actor asked absentmindedly."
                        },
                        new
                        {
                            ID = "5719b00e-676e-44d7-85fb-f68b329d3df5",
                            Sentence = "He said afternoon."
                        },
                        new
                        {
                            ID = "da7ec728-71a0-4b9a-b8f8-d3c5dbec3852",
                            Sentence = "She asked him if he was angry."
                        });
                });

            modelBuilder.Entity("SentenceConstruction.Repository.Models.Words", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Words");

                    b.HasData(
                        new
                        {
                            ID = "189d8d0b-8366-4aa2-8a9f-59df8143ccd9",
                            Name = "Nouns",
                            Word = "Actor,Gold,Painting,Advertisement,Grass,Parrot,Afternoon,Greece,Pencil,Airport,Guitar,Piano,Ambulance,Hair,Pillow,Animal,Hamburger,Pizza,Answer,Helicopter,Planet"
                        },
                        new
                        {
                            ID = "ba14a904-62cc-4e5b-9cd7-cae1e4ccf882",
                            Name = "Verbs",
                            Word = "to ask,asked,ask,will ask,to be,was,am,will be,to become,became,become,will become,to bring,brought,bring,will bring,to build,built,build,will build,to buy,bought,buy,will buy,to call,called,call,will call,to change,changed,change,will change"
                        },
                        new
                        {
                            ID = "ac398e7a-4ed9-40b6-99e0-d324d6053eee",
                            Name = "Adjectives",
                            Word = "adorable,adventurous,aggressive,agreeable,alert,alive,amused,angry,annoyed,annoying,anxious,arrogant,ashamed,attractive,average,awful,bad,beautiful,better,bewildered,black,bloody,blue,blue-eyed,blushing,bored,brainy,brave,breakable,bright,busy,calm,careful"
                        },
                        new
                        {
                            ID = "15a9a9f8-d0c5-421b-881e-54010b7d595e",
                            Name = "Adverbs",
                            Word = "absentmindedly,adoringly,awkwardly,beautifully,briskly,brutally,carefully,cheerfully,competitively,eagerly,effortlessly,extravagantly,girlishly,gracefully,grimly,happily,halfheartedly,hungrily,lazily,lifelessly,loyally,quickly,quietly,quizzically,really,recklessly,remorsefully,ruthlessly,savagely,sloppily,so,stylishly,unabashedly,unevenly,urgently,well,wishfully,worriedly"
                        },
                        new
                        {
                            ID = "f622b7ae-c7b3-460b-850e-f2025e06db46",
                            Name = "Pronouns",
                            Word = "I,you,he,she,it,we,they,me,him,her,us,them,who,whom,which,what,whose,whoever,whatever,whichever,whomever,this,that,these,those,myself,yourself,himself,herself,itself,ourselves,themselves"
                        },
                        new
                        {
                            ID = "26b7dc7e-55dd-4215-b539-d9070e99a90c",
                            Name = "Prepositions",
                            Word = "aboard,about,above,according to,across,after,against,ahead of,along,amid,amidst,among,around,as,as far as,as of,aside from,at,athwart,atop,of,off,on,on account of,on behalf of,on top of,onto,opposite,out,out of,outside,over,with,with regard to,within,without,regarding,regardless of"
                        },
                        new
                        {
                            ID = "dbaecc51-6fe9-4630-b42e-2a20a2a20dc6",
                            Name = "Conjunctions",
                            Word = "After,As,As long as,As soon as,As though,Before,Even if,If,If when,Inasmuch,Just as,Now,Now that,Once,Provided that,Since,Supposing,That,Though,Until,Whenever,Whereas,Wherever,Which,Who,Although,As if,As much as,Because,Even,Even though,If only,If then,In order that,Lest,Now since,Now when,Provided,Rather than,So that,After all,As a result,Consequently,Finally,For example,Furthermore,Hence,However,In addition,In fact,Incidentally,Indeed,Instead,Likewise,Meanwhile"
                        },
                        new
                        {
                            ID = "4272a9d8-bf92-460b-a1f5-a362052e1519",
                            Name = "Determiners",
                            Word = "a,a few,a little,all,an,another,any,anybody,anyone,anything,anywhere,both,certain,each,either,enough,every,everybody,everyone,everything,everywhere,few,fewer,fewest,last,least,less,little,many,many a,more,most,much,neither,next,no,no one,nobody,none,nothing,nowhere,once,one,said,several,some,somebody,something,somewhere,sufficient,that,the,these"
                        },
                        new
                        {
                            ID = "46ed68fc-5f35-49ca-a9cb-8a541990b110",
                            Name = "Exclamations",
                            Word = "Shh,Please,Psst,Shoo,Hey,Oh,Yo,Here,Ahem,Encore,There,Hush,Scat,No,Silence,Enough'Yuck,Eww,Aww,Ouch,Oh,Ah,Ugh,Phew,Phooey,Rats,Yippee,Blah,Brr,Eek,Good grief,Alas,Bingo,Bravo,Eureka,Crikey,Gee,Golly,Gosh,Hmm,Holy cow,Aha,Oh,Huh,Duh,Ahh,Well"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
