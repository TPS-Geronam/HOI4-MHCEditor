using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H4MHCEditor {
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }

        private void advisorAddButton_Click(object sender, EventArgs e) {
            if(!modDirectoryTextbox.Text.EndsWith("\\toi")) {
                errorLabel.Text = "Please select a valid EoaNB directory (has to end with \"\\toi\").";
            } else {
                if (advisorNameTextbox.Text.Equals("")) {
                    errorLabel.Text = "Please enter a valid advisor name.";
                } else {
                    if(advisorGfxIdTextbox.Text.Equals("")) {
                        errorLabel.Text = "Please enter a valid GFX ID.";
                    } else {
                        if(countryTagTextbox.Text.Equals("") || countryTagTextbox.Text.Length > 3 || countryTagTextbox.Text.ToUpper() != countryTagTextbox.Text) {
                            errorLabel.Text = "Please enter a valid tag (upper case).";
                        } else {
                            if(advisorLocKeyTextbox.Text.Equals("")) {
                                errorLabel.Text = "Please generate a loc key.";
                            } else {
                                if(advisorTypeCheckboxList.GetItemCheckState(0) == CheckState.Unchecked && advisorTypeCheckboxList.GetItemCheckState(1) == CheckState.Unchecked && advisorTypeCheckboxList.GetItemCheckState(2) == CheckState.Unchecked) {
                                    errorLabel.Text = "Please select the advisor's organisation.";
                                } else {
                                    if(ASCIIEncoding.GetEncoding(0).GetString(ASCIIEncoding.GetEncoding(0).GetBytes(advisorLocKeyTextbox.Text)) != advisorLocKeyTextbox.Text) {
                                        errorLabel.Text = "Please replace any non-UTF-8 chars in the loc key.";
                                    } else {
                                        errorLabel.Text = "";

                                        string locFile = $"{modDirectoryTextbox.Text}\\localisation\\mhc_names_{countryTagTextbox.Text}_l_english.yml";
                                        if(!File.Exists(locFile)) {
                                            File.Copy(Environment.CurrentDirectory + "\\res\\mhc_names_TAG_l_english.yml", locFile);
                                        }
                                        string text = File.ReadAllText(locFile);

                                        namesSetup(countryTagTextbox.Text);
                                        logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: General names setup done\n");

                                        if(advisorTypeCheckboxList.GetItemCheckState(0) == CheckState.Checked) {
                                            // army
                                            text = text.Replace("###Army Replacement Marker###", $"{advisorLocKeyTextbox.Text}:0 \"{advisorNameTextbox.Text}\"\n ###Army Replacement Marker###");
                                            replaceArmyIconSetup(countryTagTextbox.Text);
                                            tagArmyIconSetup(countryTagTextbox.Text);
                                            selectorArmySetup(countryTagTextbox.Text);
                                            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Army GFX setup done\n");
                                            tagNamesSetup(countryTagTextbox.Text, 0);
                                            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Army TAG name setup done\n");
                                        } else if(advisorTypeCheckboxList.GetItemCheckState(1) == CheckState.Checked) {
                                            // airforce
                                            text = text.Replace("###Airforce Replacement Marker###", $"{advisorLocKeyTextbox.Text}:0 \"{advisorNameTextbox.Text}\"\n ###Airforce Replacement Marker###");
                                            replaceAirforceIconSetup(countryTagTextbox.Text);
                                            tagAirforceIconSetup(countryTagTextbox.Text);
                                            selectorAirforceSetup(countryTagTextbox.Text);
                                            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Airforce GFX setup done\n");
                                            tagNamesSetup(countryTagTextbox.Text, 1);
                                            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Airforce TAG name setup done\n");
                                        } else if(advisorTypeCheckboxList.GetItemCheckState(2) == CheckState.Checked) {
                                            // navy
                                            text = text.Replace("###Navy Replacement Marker###", $"{advisorLocKeyTextbox.Text}:0 \"{advisorNameTextbox.Text}\"\n ###Navy Replacement Marker###");
                                            replaceNavyIconSetup(countryTagTextbox.Text);
                                            tagNavyIconSetup(countryTagTextbox.Text);
                                            selectorNavySetup(countryTagTextbox.Text);
                                            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Navy GFX setup done\n");
                                            tagNamesSetup(countryTagTextbox.Text, 2);
                                            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Navy TAG name setup done\n");
                                        }

                                        // loc file is saved
                                        File.WriteAllText(locFile, text);
                                        logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Loc file setup done\n");

                                        if(advisorMhcIdCheckbox.Checked) {
                                            advisorMhcIdNumeric.Value = advisorMhcIdNumeric.Value + 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void startupButton_Click(object sender, EventArgs e) {
            if(!modDirectoryTextbox.Text.EndsWith("\\toi")) {
                errorLabel.Text = "Please select a valid EoaNB directory (has to end with \"\\toi\").";
            } else {
                if(advisorNameTextbox.Text.Equals("")) {
                    errorLabel.Text = "Please enter a valid advisor name.";
                } else {
                    if(advisorGfxIdTextbox.Text.Equals("")) {
                        errorLabel.Text = "Please enter a valid GFX ID.";
                    } else {
                        if(countryTagTextbox.Text.Equals("") || countryTagTextbox.Text.Length > 3 || countryTagTextbox.Text.ToUpper() != countryTagTextbox.Text) {
                            errorLabel.Text = "Please enter a valid tag (upper case).";
                        } else {
                            if(advisorLocKeyTextbox.Text.Equals("")) {
                                errorLabel.Text = "Please generate a loc key.";
                            } else {
                                if(advisorTypeCheckboxList.GetItemCheckState(0) == CheckState.Unchecked && advisorTypeCheckboxList.GetItemCheckState(1) == CheckState.Unchecked && advisorTypeCheckboxList.GetItemCheckState(2) == CheckState.Unchecked) {
                                    errorLabel.Text = "Please select the advisor's organisation.";
                                } else {
                                    if(ASCIIEncoding.GetEncoding(0).GetString(ASCIIEncoding.GetEncoding(0).GetBytes(advisorLocKeyTextbox.Text)) != advisorLocKeyTextbox.Text) {
                                        errorLabel.Text = "Please replace any non-UTF-8 chars in the loc key.";
                                    } else {
                                        if(startupBookmarkCheckboxList.GetItemCheckState(0) == CheckState.Unchecked) {
                                            errorLabel.Text = "Please select a bookmark.";
                                        } else {
                                            errorLabel.Text = "";

                                            Directory.CreateDirectory($"{modDirectoryTextbox.Text}\\documentation\\MHC advisors\\{countryTagTextbox.Text}\\");

                                            string setupFile = $"{modDirectoryTextbox.Text}\\common\\scripted_effects\\00_mhc_setup_effects.txt";
                                            string text = File.ReadAllText(setupFile);

                                            string highAddition = "";
                                            if(advisorTypeCheckboxList.GetItemCheckState(0) == CheckState.Checked) {
                                                // army
                                                if(!text.Contains($"###{countryTagTextbox.Text} Army Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###")) {
                                                    text = text.Replace($"###Army Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###", $"###{countryTagTextbox.Text} START###\n\t\t{countryTagTextbox.Text} = {{\n\t\t\tadd_to_array = {{ # position 0 is null value\n\t\t\t\tarray = local_mhc_army_available_traits_array\n\t\t\t\tindex = 0\n\t\t\t\tvalue = 0\n\t\t\t}}\n\n\t\t\t###{countryTagTextbox.Text} Army Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###\n\t\t}}\n\t\t###{countryTagTextbox.Text} END###\n\n\t\t###Army Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###");
                                                }

                                                if(startupHighCheckbox.Checked) {
                                                    highAddition = "mhc_add_mark_advisor_as_high_army_brass = yes\n";
                                                }

                                                text = text.Replace($"###{countryTagTextbox.Text} Army Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###", $"set_temp_variable = {{ temp_advisor_frame = {advisorMhcIdNumeric.Value} }}\n\t\t\tset_temp_variable = {{ temp_advisor_trait = {startupTraitNumeric.Value} }}\n\t\t\tmhc_add_army_advisor = yes\n\t\t\t{highAddition}\n\t\t\t###{countryTagTextbox.Text} Army Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###");

                                                if(!File.Exists($"{modDirectoryTextbox.Text}\\documentation\\MHC advisors\\{countryTagTextbox.Text}\\{countryTagTextbox.Text}_army.csv")) {
                                                    string docArmy = "mhc_id;loc_key;trait;gfx_id;high_command\n";
                                                    File.WriteAllText($"{modDirectoryTextbox.Text}\\documentation\\MHC advisors\\{countryTagTextbox.Text}\\{countryTagTextbox.Text}_army.csv", docArmy, Encoding.UTF8);
                                                }
                                                string docHigh = "no";
                                                if(startupHighCheckbox.Checked) {
                                                    docHigh = "yes";
                                                }
                                                File.AppendAllText($"{modDirectoryTextbox.Text}\\documentation\\MHC advisors\\{countryTagTextbox.Text}\\{countryTagTextbox.Text}_army.csv", $"{advisorMhcIdNumeric.Value};{advisorLocKeyTextbox.Text};{startupTraitNumeric.Value};{advisorGfxIdTextbox.Text};{docHigh}\n");
                                            } else if(advisorTypeCheckboxList.GetItemCheckState(1) == CheckState.Checked) {
                                                // airforce
                                                if(!text.Contains($"###{countryTagTextbox.Text} Airforce Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###")) {
                                                    text = text.Replace($"###Airforce Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###", $"###{countryTagTextbox.Text} START###\n\t\t{countryTagTextbox.Text} = {{\n\t\t\t# airforce founded flag\n\t\t\tset_country_flag = air_force_founded\n\n\t\t\tadd_to_array = {{ # position 0 is null value\n\t\t\t\tarray = local_mhc_airforce_available_traits_array\n\t\t\t\tindex = 0\n\t\t\t\tvalue = 0\n\t\t\t}}\n\n\t\t\t###{countryTagTextbox.Text} Airforce Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###\n\t\t}}\n\t\t###{countryTagTextbox.Text} END###\n\n\t\t###Airforce Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###");
                                                }

                                                if(startupHighCheckbox.Checked) {
                                                    highAddition = "mhc_add_mark_advisor_as_high_airforce_brass = yes\n";
                                                }

                                                text = text.Replace($"###{countryTagTextbox.Text} Airforce Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###", $"set_temp_variable = {{ temp_advisor_frame = {advisorMhcIdNumeric.Value} }}\n\t\t\tset_temp_variable = {{ temp_advisor_trait = {startupTraitNumeric.Value} }}\n\t\t\tmhc_add_airforce_advisor = yes\n\t\t\t{highAddition}\n\t\t\t###{countryTagTextbox.Text} Airforce Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###");

                                                if(!File.Exists($"{modDirectoryTextbox.Text}\\documentation\\MHC advisors\\{countryTagTextbox.Text}\\{countryTagTextbox.Text}_airforce.csv")) {
                                                    string docAirforce = "mhc_id;loc_key;trait;gfx_id;high_command\n";
                                                    File.WriteAllText($"{modDirectoryTextbox.Text}\\documentation\\MHC advisors\\{countryTagTextbox.Text}\\{countryTagTextbox.Text}_airforce.csv", docAirforce, Encoding.UTF8);
                                                }
                                                string docHigh = "no";
                                                if(startupHighCheckbox.Checked) {
                                                    docHigh = "yes";
                                                }
                                                File.AppendAllText($"{modDirectoryTextbox.Text}\\documentation\\MHC advisors\\{countryTagTextbox.Text}\\{countryTagTextbox.Text}_airforce.csv", $"{advisorMhcIdNumeric.Value};{advisorLocKeyTextbox.Text};{startupTraitNumeric.Value};{advisorGfxIdTextbox.Text};{docHigh}\n");
                                            } else if(advisorTypeCheckboxList.GetItemCheckState(2) == CheckState.Checked) {
                                                // navy
                                                if(!text.Contains($"###{countryTagTextbox.Text} Navy Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###")) {
                                                    text = text.Replace($"###Navy Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###", $"###{countryTagTextbox.Text} START###\n\t\t{countryTagTextbox.Text} = {{\n\t\t\t# navy founded flag\n\t\t\tset_country_flag = naval_command_founded\n\n\t\t\tadd_to_array = {{ # position 0 is null value\n\t\t\t\tarray = local_mhc_navy_available_traits_array\n\t\t\t\tindex = 0\n\t\t\t\tvalue = 0\n\t\t\t}}\n\n\t\t\t###{countryTagTextbox.Text} Navy Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###\n\t\t}}\n\t\t###{countryTagTextbox.Text} END###\n\n\t\t###Navy Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###");
                                                }

                                                if(startupHighCheckbox.Checked) {
                                                    highAddition = "mhc_add_mark_advisor_as_high_navy_brass = yes\n";
                                                }

                                                text = text.Replace($"###{countryTagTextbox.Text} Navy Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###", $"set_temp_variable = {{ temp_advisor_frame = {advisorMhcIdNumeric.Value} }}\n\t\t\tset_temp_variable = {{ temp_advisor_trait = {startupTraitNumeric.Value} }}\n\t\t\tmhc_add_navy_advisor = yes\n\t\t\t{highAddition}\n\t\t\t###{countryTagTextbox.Text} Navy Replacement Marker {startupBookmarkCheckboxList.CheckedItems[0]}###");

                                                if(!File.Exists($"{modDirectoryTextbox.Text}\\documentation\\MHC advisors\\{countryTagTextbox.Text}\\{countryTagTextbox.Text}_navy.csv")) {
                                                    string docNavy = "mhc_id;loc_key;trait;gfx_id;high_command\n";
                                                    File.WriteAllText($"{modDirectoryTextbox.Text}\\documentation\\MHC advisors\\{countryTagTextbox.Text}\\{countryTagTextbox.Text}_navy.csv", docNavy, Encoding.UTF8);
                                                }
                                                string docHigh = "no";
                                                if(startupHighCheckbox.Checked) {
                                                    docHigh = "yes";
                                                }
                                                File.AppendAllText($"{modDirectoryTextbox.Text}\\documentation\\MHC advisors\\{countryTagTextbox.Text}\\{countryTagTextbox.Text}_navy.csv", $"{advisorMhcIdNumeric.Value};{advisorLocKeyTextbox.Text};{startupTraitNumeric.Value};{advisorGfxIdTextbox.Text};{docHigh}\n");
                                            }

                                            File.WriteAllText(setupFile, text, Encoding.UTF8);
                                            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Bookmark effects file setup done\n");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #region names
        private void namesSetup(string tag) {
            string text = File.ReadAllText($"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_names_setup.txt");

            text = text.Replace("###Names Setup Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + countryTagTextbox.Text + "\n\t\t\tcheck_variable = { show_local_mhc_tab = 0 }\n\t\t\tmhc_is_generic_army_advisor_selector_trigger = no\n\t\t}\n\t\tlocalization_key = \"MHC_SELECTOR_ENTRY_NAME_ARMY_" + countryTagTextbox.Text + "\"\n\t}" +
                "\n\ttext = {\n\t\ttrigger = {\n\t\t\ttag = " + countryTagTextbox.Text + "\n\t\t\tcheck_variable = { show_local_mhc_tab = 1 }\n\t\t\tmhc_is_generic_navy_advisor_selector_trigger = no\n\t\t}\n\t\tlocalization_key = \"MHC_SELECTOR_ENTRY_NAME_NAVY_" + countryTagTextbox.Text + "\"\n\t}" +
                "\n\ttext = {\n\t\ttrigger = {\n\t\t\ttag = " + countryTagTextbox.Text + "\n\t\t\tcheck_variable = { show_local_mhc_tab = 2 }\n\t\t\tmhc_is_generic_airforce_advisor_selector_trigger = no\n\t\t}\n\t\tlocalization_key = \"MHC_SELECTOR_ENTRY_NAME_AIRFORCE_" + countryTagTextbox.Text + "\"\n\t}" +
                "\n\t\n\t###Names Setup Replacement Marker###");

            File.WriteAllText($"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_names_setup.txt", text, Encoding.UTF8);
            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added names to 00_mhc_names_setup.txt\n");
        }

        private void tagNamesSetup(string tag, int type) {
            string namesFile = $"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_names_{countryTagTextbox.Text}.txt";
            if(!File.Exists(namesFile)) {
                File.Copy(Environment.CurrentDirectory + "\\res\\00_mhc_names_TAG.txt", namesFile);
            }
            string text = File.ReadAllText(namesFile);

            text = text.Replace("TAG", countryTagTextbox.Text);
            if(type == 0) {
                text = text.Replace("###Army Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { v = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorLocKeyTextbox.Text + "\"\n\t}\n\t###Army Replacement Marker###");
            } else if(type == 1) {
                text = text.Replace("###Airforce Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { v = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorLocKeyTextbox.Text + "\"\n\t}\n\t###Airforce Replacement Marker###");
            } else if(type == 2) {
                text = text.Replace("###Navy Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { v = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorLocKeyTextbox.Text + "\"\n\t}\n\t###Navy Replacement Marker###");
            }

            File.WriteAllText(namesFile, text, Encoding.UTF8);
            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added names to 00_mhc_names_{countryTagTextbox.Text}.txt\n");
        
            string locFile = $"{modDirectoryTextbox.Text}\\localisation\\mhc_names_l_english.yml";
            text = File.ReadAllText(locFile);
            string toBeInserted = $" MHC_SELECTOR_ENTRY_NAME_ARMY_{countryTagTextbox.Text}:0 \"[MHC_SELECTOR_ENTRY_NAME_ARMY_{countryTagTextbox.Text}_PROXY]\"\n MHC_SELECTOR_ENTRY_NAME_AIRFORCE_{countryTagTextbox.Text}:0 \"[MHC_SELECTOR_ENTRY_NAME_AIRFORCE_{countryTagTextbox.Text}_PROXY]\"\n MHC_SELECTOR_ENTRY_NAME_NAVY_{countryTagTextbox.Text}:0 \"[MHC_SELECTOR_ENTRY_NAME_NAVY_{countryTagTextbox.Text}_PROXY]\"";
            if(!text.Contains(toBeInserted)) {
                text = text.Replace("###MHC Name Proxy Replacement Marker###", toBeInserted);
                File.WriteAllText(locFile, text, Encoding.UTF8);
                logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added name proxy to mhc_names_l_english.yml\n");
            }
        }
        #endregion

        #region selector icons
        private void selectorArmySetup(string tag) {
            string armyFile = $"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_army_selector_icons.txt";
            string text = File.ReadAllText(armyFile);

            if(!text.Contains($"###{countryTagTextbox.Text} Replacement Marker###")) {
                text = text.Replace("###Army Replacement Marker###", $"###{countryTagTextbox.Text} START###\n\t###{countryTagTextbox.Text} Replacement Marker###\n\t###{countryTagTextbox.Text} END###\n\n\t###Army Replacement Marker###");
            }

            text = text.Replace($"###{countryTagTextbox.Text} Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + countryTagTextbox.Text + "\n\t\t\tNOT = { mhc_is_generic_army_advisor_selector_trigger = yes }\n\t\t\tcheck_variable = { v = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t" + $"###{countryTagTextbox.Text} Replacement Marker###");

            File.WriteAllText(armyFile, text, Encoding.UTF8);
            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added army icons to 00_mhc_army_selector_icons.txt\n");
        }

        private void selectorAirforceSetup(string tag) {
            string airforceFile = $"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_airforce_selector_icons.txt";
            string text = File.ReadAllText(airforceFile);

            if(!text.Contains($"###{countryTagTextbox.Text} Replacement Marker###")) {
                text = text.Replace("###Airforce Replacement Marker###", $"###{countryTagTextbox.Text} START###\n\t###{countryTagTextbox.Text} Replacement Marker###\n\t###{countryTagTextbox.Text} END###\n\n\t###Airforce Replacement Marker###");
            }

            text = text.Replace($"###{countryTagTextbox.Text} Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + countryTagTextbox.Text + "\n\t\t\tNOT = { mhc_is_generic_airforce_advisor_selector_trigger = yes }\n\t\t\tcheck_variable = { v = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t" + $"###{countryTagTextbox.Text} Replacement Marker###");

            File.WriteAllText(airforceFile, text, Encoding.UTF8);
            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added airforce icons to 00_mhc_army_selector_icons.txt\n");
        }

        private void selectorNavySetup(string tag) {
            string navyFile = $"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_navy_selector_icons.txt";
            string text = File.ReadAllText(navyFile);

            if(!text.Contains($"###{countryTagTextbox.Text} Replacement Marker###")) {
                text = text.Replace("###Navy Replacement Marker###", $"###{countryTagTextbox.Text} START###\n\t###{countryTagTextbox.Text} Replacement Marker###\n\t###{countryTagTextbox.Text} END###\n\n\t###Navy Replacement Marker###");
            }

            text = text.Replace($"###{countryTagTextbox.Text} Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + countryTagTextbox.Text + "\n\t\t\tNOT = { mhc_is_generic_navy_advisor_selector_trigger = yes }\n\t\t\tcheck_variable = { v = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t" + $"###{countryTagTextbox.Text} Replacement Marker###");

            File.WriteAllText(navyFile, text, Encoding.UTF8);
            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added navy icons to 00_mhc_army_selector_icons.txt\n");
        }
        #endregion

        #region tag icons
        private void tagArmyIconSetup(string tag) {
            string armyFile = $"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_army_icons_{countryTagTextbox.Text}.txt";
            if(!File.Exists(armyFile)) {
                File.Copy(Environment.CurrentDirectory + "\\res\\00_mhc_army_icons_TAG.txt", armyFile);
            }
            string text = File.ReadAllText(armyFile);

            text = text.Replace("TAG", countryTagTextbox.Text);
            // sec
            text = text.Replace("###Army Sec Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_sec_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Army Sec Replacement Marker###");
            // chief
            text = text.Replace("###Army Chief Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_chief_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Army Chief Replacement Marker###");
            // vchief
            text = text.Replace("###Army VChief Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_vchief_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Army VChief Replacement Marker###");
            // quart
            text = text.Replace("###Army Quart Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_quart_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Army Quart Replacement Marker###");
            // pchief
            text = text.Replace("###Army PChief Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_pchief_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Army PChief Replacement Marker###");
            // ins
            text = text.Replace("###Army Ins Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_ins_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Army Ins Replacement Marker###");
            File.WriteAllText(armyFile, text, Encoding.UTF8);
            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added army icons to 00_mhc_army_icons_{countryTagTextbox.Text}.txt\n");
        }

        private void tagAirforceIconSetup(string tag) {
            string airforceFile = $"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_airforce_icons_{countryTagTextbox.Text}.txt";
            if(!File.Exists(airforceFile)) {
                File.Copy(Environment.CurrentDirectory + "\\res\\00_mhc_airforce_icons_TAG.txt", airforceFile);
            }
            string text = File.ReadAllText(airforceFile);

            text = text.Replace("TAG", countryTagTextbox.Text);
            // afc
            text = text.Replace("###Airforce Afc Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_afc_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Airforce Afc Replacement Marker###");
            // ach
            text = text.Replace("###Airforce Ach Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_ach_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Airforce Ach Replacement Marker###");
            // opg
            text = text.Replace("###Airforce Opg Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_opg_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Airforce Opg Replacement Marker###");
            // wic
            text = text.Replace("###Airforce Wic Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_wic_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Airforce Wic Replacement Marker###");
            // supc
            text = text.Replace("###Airforce Supc Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_supc_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Airforce Supc Replacement Marker###");
            File.WriteAllText(airforceFile, text, Encoding.UTF8);
            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added airforce icons to 00_mhc_army_icons_{countryTagTextbox.Text}.txt\n");
        }

        private void tagNavyIconSetup(string tag) {
            string navyFile = $"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_navy_icons_{countryTagTextbox.Text}.txt";
            if(!File.Exists(navyFile)) {
                File.Copy(Environment.CurrentDirectory + "\\res\\00_mhc_navy_icons_TAG.txt", navyFile);
            }
            string text = File.ReadAllText(navyFile);

            text = text.Replace("TAG", countryTagTextbox.Text);
            // nas
            text = text.Replace("###Navy Nas Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_nas_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Navy Nas Replacement Marker###");
            // ncs
            text = text.Replace("###Navy Ncs Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_ncs_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Navy Ncs Replacement Marker###");
            // nog
            text = text.Replace("###Navy Nog Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_nog_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Navy Nog Replacement Marker###");
            // cog
            text = text.Replace("###Navy Cog Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_cog_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Navy Cog Replacement Marker###");
            // nlg
            text = text.Replace("###Navy Nlg Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_nlg_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Navy Nlg Replacement Marker###");
            // mog
            text = text.Replace("###Navy Mog Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\tcheck_variable = { mhc_mog_value = " + advisorMhcIdNumeric.Value + " }\n\t\t}\n\t\tlocalization_key = \"" + advisorGfxIdTextbox.Text + "\"\n\t}\n\t###Navy Mog Replacement Marker###");
            File.WriteAllText(navyFile, text, Encoding.UTF8);
            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added navy icons to 00_mhc_army_icons_{countryTagTextbox.Text}.txt\n");
        }
        #endregion

        #region icon setup
        private void replaceArmyIconSetup(string tag) {
            string text = File.ReadAllText($"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_army_icons_setup.txt");
            // sec
            text = text.Replace("###Army Sec Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCArmySecImage" + tag +"]\"\n\t}\n\t###Army Sec Replacement Marker###");
            // chief
            text = text.Replace("###Army Chief Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCArmyChiefImage" + tag + "]\"\n\t}\n\t###Army Chief Replacement Marker###");
            // vchief
            text = text.Replace("###Army VChief Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCArmyVChiefImage" + tag + "]\"\n\t}\n\t###Army VChief Replacement Marker###");
            // quart
            text = text.Replace("###Army Quart Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCArmyQuartImage" + tag + "]\"\n\t}\n\t###Army Quart Replacement Marker###");
            // pchief
            text = text.Replace("###Army PChief Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCArmyPChiefImage" + tag + "]\"\n\t}\n\t###Army PChief Replacement Marker###");
            // ins
            text = text.Replace("###Army Ins Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCArmyInsImage" + tag + "]\"\n\t}\n\t###Army Ins Replacement Marker###");
            File.WriteAllText($"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_army_icons_setup.txt", text, Encoding.UTF8);
            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added army icons to 00_mhc_army_icons_setup.txt\n");
        }

        private void replaceAirforceIconSetup(string tag) {
            string text = File.ReadAllText($"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_airforce_icons_setup.txt");
            // afc
            text = text.Replace("###Airforce Afc Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCAirforceAfcImage" + tag + "]\"\n\t}\n\t###Airforce Afc Replacement Marker###");
            // ach
            text = text.Replace("###Airforce Ach Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCAirforceAchImage" + tag + "]\"\n\t}\n\t###Airforce Ach Replacement Marker###");
            // opg
            text = text.Replace("###Airforce Opg Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCAirforceOpgImage" + tag + "]\"\n\t}\n\t###Airforce Opg Replacement Marker###");
            // wic
            text = text.Replace("###Airforce Wic Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCAirforceWicImage" + tag + "]\"\n\t}\n\t###Airforce Wic Replacement Marker###");
            // supc
            text = text.Replace("###Airforce Supc Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCAirforceSupcImage" + tag + "]\"\n\t}\n\t###Airforce Supc Replacement Marker###");
            File.WriteAllText($"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_airforce_icons_setup.txt", text, Encoding.UTF8);
            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added airforce icons to 00_mhc_army_icons_setup.txt\n");
        }

        private void replaceNavyIconSetup(string tag) {
            string text = File.ReadAllText($"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_navy_icons_setup.txt");
            // nas
            text = text.Replace("###Navy Nas Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCNavyNasImage" + tag + "]\"\n\t}\n\t###Navy Nas Replacement Marker###");
            // ncs
            text = text.Replace("###Navy Ncs Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCNavyNcsImage" + tag + "]\"\n\t}\n\t###Navy Ncs Replacement Marker###");
            // nog
            text = text.Replace("###Navy Nog Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCNavyNogImage" + tag + "]\"\n\t}\n\t###Navy Nog Replacement Marker###");
            // cog
            text = text.Replace("###Navy Cog Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCNavyCogImage" + tag + "]\"\n\t}\n\t###Navy Cog Replacement Marker###");
            // nlg
            text = text.Replace("###Navy Nlg Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCNavyNlgImage" + tag + "]\"\n\t}\n\t###Navy Nlg Replacement Marker###");
            // mog
            text = text.Replace("###Navy Mog Replacement Marker###", "text = {\n\t\ttrigger = {\n\t\t\ttag = " + tag + "\n\t\t}\n\t\tlocalization_key = \"[GetMHCNavyMogImage" + tag + "]\"\n\t}\n\t###Navy Mog Replacement Marker###");
            File.WriteAllText($"{modDirectoryTextbox.Text}\\common\\scripted_localisation\\00_mhc_navy_icons_setup.txt", text, Encoding.UTF8);
            logTextbox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: Added navy icons to 00_mhc_army_icons_setup.txt\n");
        }
        #endregion

        private void advisorGfxIdCheckbox_CheckedChanged(object sender, EventArgs e) {
            if((sender as CheckBox).Checked) {
                advisorGfxIdTextbox.Text = "GFX_MHC_no_advisor_gfx";
                advisorGfxIdTextbox.Enabled = false;
            } else {
                advisorGfxIdTextbox.Text = "";
                advisorGfxIdTextbox.Enabled = true;
            }
        }

        private void advisorMhcIdCheckbox_CheckedChanged(object sender, EventArgs e) {
            if((sender as CheckBox).Checked) {
                advisorMhcIdNumeric.Enabled = false;
            } else {
                advisorMhcIdNumeric.Enabled = true;
            }
        }

        private void modDirectoryButton_Click(object sender, EventArgs e) {
            using(var fbd = new FolderBrowserDialog()) {
                DialogResult result = fbd.ShowDialog();

                if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    modDirectoryTextbox.Text = fbd.SelectedPath;
                }
            }
        }

        private void advisorTypeCheckboxList_ItemCheck(object sender, ItemCheckEventArgs e) {
            for(int ix = 0; ix < advisorTypeCheckboxList.Items.Count; ++ix)
                if(ix != e.Index)
                    advisorTypeCheckboxList.SetItemChecked(ix, false);
        }

        private void advisorLocKeyButton_Click(object sender, EventArgs e) {
            if(advisorNameTextbox.Text.Equals("")) {
                errorLabel.Text = "Please enter a valid advisor name.";
            } else {
                if(countryTagTextbox.Text.Equals("") || countryTagTextbox.Text.Length > 3) {
                    errorLabel.Text = "Please enter a valid tag.";
                } else {
                    advisorLocKeyTextbox.Text = $"{countryTagTextbox.Text}_{advisorNameTextbox.Text.Replace(' ', '_')}";
                }
            }
        }

        private void startupBookmarkCheckboxList_ItemCheck(object sender, ItemCheckEventArgs e) {
            for(int ix = 0; ix < advisorTypeCheckboxList.Items.Count; ++ix)
                if(ix != e.Index)
                    advisorTypeCheckboxList.SetItemChecked(ix, false);
        }
    }
}