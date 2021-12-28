window.prefersDarkMode = function(){
    return window.matchMedia('(prefers-color-scheme: dark)').matches;
}