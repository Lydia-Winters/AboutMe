using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AboutMe
{
    public partial class SkillsPage : ContentPage
    {
        public ObservableCollection<SkillItem>Skills {get; set; }

        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<SkillItem>();

            SkillItem WebSkill = new SkillItem();
            WebSkill.Name = "Web Development";
            WebSkill.Icon = "codeicon.png";

            SkillItem GraphicsSkill = new SkillItem();
            GraphicsSkill.Name = "Graphic Design";
            GraphicsSkill.Icon = "graphicicon.png";

            SkillItem SewingSkill = new SkillItem();
            SewingSkill.Name = "Sewing & Crafting";
            SewingSkill.Icon = "sewingicon.png";

            SkillItem TimeSkill = new SkillItem();
            TimeSkill.Name = "Time Managenment";
            TimeSkill.Icon = "timeicon.png";

            Skills.Add(WebSkill);
            Skills.Add(GraphicsSkill);
            Skills.Add(SewingSkill);
            Skills.Add(TimeSkill);

            skillsListView.ItemsSource = this.Skills;

        }

       
    }
}
