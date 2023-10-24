Documentation Guide
===================
Once changes are pushed to the main branch, the documentation will be automatically
build at `food-fight.readthedocs.io`_. 

.. _food-fight.readthedocs.io: https://food-fight.readthedocs.io

To add documentation to this project and observe draft changes, you will 
need to make a virtual environment and build the documentation on your machine.

How to Add Documentation
------------------------
To create a virtual environment, ensure you are in the root directory of the
project. Upgrade the pip package, install the virtual environment package and
create the virtual environment. The .gitignore file will ignore your virtual
environment so it is not pushed to the branch.

.. code-block::
      
       python -m pip install --upgrade pip
       py -m pip install --user virtualenv
       python -m venv env

Next, you need to activate the environment. I would recommend using PowerShell
to activate the virtual environment.

.. code-block::

      .\env\Scripts\activate

After executing this command, a version of python should be in added to your
PATH variable. You can check this by using the following command.

.. code-block::

      (env) where python

If there isn't a python version in ...\env\Scripts\, you will need to add it to
your PATH manually. Go to Windows Start > Search "Environment Variables" and
go to "Edit the system environment variables" > Go to "Environment Variables"
in the new window > Add the ...\env\Scripts\ directory to both PATH variables
in the User Variables and System Variables. Restart your PowerShell terminal and
reactivate the environment.

Now, you need to install Sphinx. Sphinx is a tool that creates documentation using
the reStructuredText markup language. Install Sphinx in your virutal environment.

.. code-block::

      (env) pip install -U sphinx
      (env) sphinx-build --version
      sphinx-build 4.0.2

Next, all you need to do is build the existing documentation on your machine.
Navigate to the <project-root>/docs directory. Execute the following command to
build the HTML documentation.

.. code-block::

      (env) .\make.bat html

Now, navigate to the .../docs/build/directory and open the index.html. It should
display the project's documentation.

To make changes to the documentation you need to modify the individual files in
.../docs/source/. The files are .rst (reStructuredText) files. For example, the 
home page is the index.rst file while this page is the docguide.rst file. Please
reference the existing documentation and this `guide`_ for editing the documentation.

.. _guide: https://www.sphinx-doc.org/en/master/usage/restructuredtext/index.html