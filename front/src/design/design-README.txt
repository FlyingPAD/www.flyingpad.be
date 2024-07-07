=================================
- Flying PAD SCSS Documentation
=================================

1. Introduction
-----------------

 => I created a "design" folder in ./src to put all my global *scss files. 
 => Of course, I also edited "angular.json" to add these files to the angular project.

2. Description 
------------------

=> ./src/design/

 + 01_normalize.scss                 // This is the "normalize.css v8.0.1" file | github.com/necolas/normalize.css ( I'm a fan )
 + 02_global_variables.scss          // Here, you'll find global variables for the entire project ( colors, fonts, assets URL, ... )
 + 03_global_settings.scss           // Some basic global CSS configuration ( html, body, ... )

------------------------------------------------------------------------------------------------

=> ./src/design/central 

 + elements.scss                     // Global Definition for central related elements
 + component_gallery.scss            // Gallery in Normal View Mode
 + component_gallery_wall.scss       // Gallery in Wall View Mode
 + component_...                     // Specific components ... 

------------------------------------------------------------------------------------------------

=> ./src/design/menu

 + elements.scss                     // Global Definition for L & R Menu related elements
 + component_...                     // Specific components ... 