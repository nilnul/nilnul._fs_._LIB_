namespace nilnul.fs.folder.doc_.nilnulCfg {


    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
	/// <summary>
	/// doc ".nilnulCfg" is used to book settings of the container, which is a folder.
	/// eg:
	///		in git, we may use this to describe the folder if we don't have the ".git" repo dir (if we have the ".git" repo, we can set values there; but sometimes we don't want to init a repo, as in the case we wang to ignore a folder when creating repo)
	///	when the settings are too much, we may use a folder named ".nilnul" or ".nilnulCfg" to contain many settings.
	/// </summary>
    public sealed partial class Settings1 {
        
        public Settings1() {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Add code to handle the SettingChangingEvent event here.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Add code to handle the SettingsSaving event here.
        }
    }
}
