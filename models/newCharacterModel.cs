using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using MageTower.functions;

namespace MageTower.models
{
    public class newCharacterModel : INotifyPropertyChanged
    {
        private PlayerData playerCharacter;
        public event PropertyChangedEventHandler PropertyChanged;
        public PlayerData PlayerCharacter
        {
            get => playerCharacter;
            set
            {
                playerCharacter = value;
                OnPropertyChanged(nameof(PlayerCharacter));
            }
        }
        public ICommand AddStrengthCommand { get; private set; }
        public ICommand AddDexterityCommand { get; private set; }
        public ICommand AddStaminaCommand { get; private set; }
        public ICommand AddIntellectCommand { get; private set; }
        public ICommand AddFocusCommand { get; private set; }
        public ICommand AddWisdomCommand { get; private set; }
        public ICommand createCharacterCommand { get; private set; }



        public newCharacterModel()
        {
            playerCharacter = new PlayerData();
            createCharacterCommand = new RelayCommand(o => createCharacterButton(), o => true);
            AddStrengthCommand = new RelayCommand(o => addStrength(), o => true);
            AddDexterityCommand = new RelayCommand(o => addDexterity(), o => true);
            AddStaminaCommand = new RelayCommand(o => addStamina(), o => true);
            AddIntellectCommand = new RelayCommand(o => addIntellect(), o => true);
            AddFocusCommand = new RelayCommand(o => addFocus(), o => true);
            AddWisdomCommand = new RelayCommand(o => addWisdom(), o => true);

        }
        public void createCharacterButton()
        {
            MessageBox.Show("This worked! So far....");
        }
        private void addStrength()
        {

            if (PlayerCharacter.SkillPoints > 0)
            {
                PlayerCharacter.SkillPoints = PlayerCharacter.SkillPoints - 1;
                PlayerCharacter.Strength += 1;
                
            }
            else
            {
                MessageBox.Show($"Not enough skill points: '{PlayerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        private void addDexterity()
        {

            if (playerCharacter.SkillPoints > 0)
            {
                playerCharacter.SkillPoints = playerCharacter.SkillPoints - 1;
                playerCharacter.Dexterity += 1;
            }
            else
            {
                MessageBox.Show($"Not enough skill points: '{playerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        private void addStamina()
        {

            if (playerCharacter.SkillPoints > 0)
            {
                playerCharacter.SkillPoints = playerCharacter.SkillPoints - 1;
                playerCharacter.Stamina += 1;
                playerCharacter.PlayerHealth = 100 + (playerCharacter.Stamina * 2);
                playerCharacter.PlayerHealthMax = playerCharacter.PlayerHealth;
            }
            else
            {
                MessageBox.Show($"Not enough skill points: '{playerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        private void addIntellect()
        {

            if (playerCharacter.SkillPoints > 0)
            {
                playerCharacter.SkillPoints = playerCharacter.SkillPoints - 1;
                playerCharacter.Intellect += 1;
            }
            else
            {
                MessageBox.Show($"Not enough skill points: '{playerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        private void addFocus()
        {

            if (playerCharacter.SkillPoints > 0)
            {
                playerCharacter.SkillPoints = playerCharacter.SkillPoints - 1;
                playerCharacter.Focus += 1;
            }
            else
            {
                MessageBox.Show($"Not enough skill points: '{playerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        private void addWisdom()
        {

            if (playerCharacter.SkillPoints > 0)
            {
                playerCharacter.SkillPoints = playerCharacter.SkillPoints - 1;
                playerCharacter.Wisdom += 1;
                playerCharacter.PlayerMagic = 100 + (playerCharacter.Wisdom * 3);
                playerCharacter.PlayerMagicMax = playerCharacter.PlayerMagic;
            }
            else
            {
                MessageBox.Show($"Not enough skill points: '{playerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        public List<PlayerClass> AvailableClasses { get; } = new List<PlayerClass>
        {
            PlayerClass.Warrior,
            PlayerClass.Mage,
            PlayerClass.Paladin,
            PlayerClass.Rogue,
            PlayerClass.Priest,
            PlayerClass.Shaman,
            PlayerClass.Druid
        };

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
