using CardLib;
using ConsoleBlackJack;
using System;
using System.Linq;

namespace TestLocig
{
    public class TestGame
    {

        public TestGame(Action showState)
        {
            Deck = new CardSet();
            Deck.Full();
            Player = new Player();
            Table = new CardSet();
            ShowState = showState;
        }

        public Action ShowState { get; set; }
        public CardSet Deck { get; set; }
        public Player Player { get; set; }
        public CardSet Table { get; set; }

        public void Turn(Card card)
        {
            if (!Player.Hand.Contains(card)) return;
            Table.Add(Player.Hand.Pull(card));
            ShowState();
        }

        public void Start()
        {
            Player.Hand.Add(Deck.Deal(10));
            ShowState();
        }

    }
}