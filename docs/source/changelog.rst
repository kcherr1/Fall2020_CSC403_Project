Changelog
=========

.. note::
   Once you have completed your feature implementation and documentation, please update
   the changelog according to the existing format (your user, user story/major task 
   description, and pull request in each bullet point). 

Version 0.1.0
-------------
**Date:** 24 October 2023

**Features:**

- `@Jonah`_: Added experience system (#?)

	- Enemies give player experience
	- Player scales in health and strength as they level up
	- Added experience and level interface

- `@Kennedy`_: Added weapons system (#?)
- `@Luke`_: Added player lose condition when player dies (`#10 <https://github.com/briannaosms/Food-Fight/pull/10>`_)

	- Designed Restart screen for when IsAlive is false
	- When "Yes" button is clicked, application restarts
	- When "No" button is clicked, environment is closed

- `@Jonah`_: Added player win condition when boss is defeated (#?)
- `@Kennedy`_: Added healing system (#?)
- `@Brianna`_: Added documentation configuration files (`#4 <https://github.com/briannaosms/Food-Fight/pull/4>`_)

**Bug Fixes:**

- `@Brianna`_: Fixed level textures scaling (#?)
- `@Luke`_: Enemies disappear after defeat (`#7 <https://github.com/briannaosms/Food-Fight/pull/7>`_)
	
	- Added "IsAlive" variable to character class
	- Added gravestone.png to project resources
	- Added function that turns enemy pictures to gravestone when IsAlive is false

- `@Brianna`_: Fixed crash when battle window closes (`#1 <https://github.com/briannaosms/Food-Fight/pull/1>`_)

.. _@Brianna: https://github.com/briannaosms
.. _@Kennedy: https://github.com/kennedyford
.. _@Jonah: https://github.com/jonahf0
.. _@Luke: https://github.com/ldm04


Version 0.0.0
-------------
**Date:** 19 October 2023

* Original `code base`_ assigned

.. _code base: https://github.com/kcherr1/Fall2020_CSC403_Project