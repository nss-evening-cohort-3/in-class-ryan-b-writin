# Basics Of Forms

Purpose of this project is to help the students understand the basics of HTML forms. After instruction, the Students will be tasked with making both Razor and HTML forms.

## Part 1 - Initial Setup

Install and configure AngularJS Core.

## Part 2 - New Controller and View

Add a new **empty** controller named, `BasicsController`. Add a new Controller action named `Index` with a Razor view named `Index.cshtml`.

## Part 3 - HTML forms

Create an HTML form BY HAND in your `Index.cshtml` that contains input fields for Email, Password and Password Confirmation. (you may use a Razor helper for your AntiForgery Token). Be sure to include a submit button.

## Part 4 - Submit your HTML form

Add a new action to your `BasicsController` to accept a POST from your HTML form in `Index.cshtml`. (it'll be a good idea to set a breakpoint in your controller).

## Part 5 - Create a Razor Form

Create a new controller action (in your `BasicsController`) named `Razor` with a matching view named, `Razor.cshtml`. This view should contain a form created with Razor. This Razor form should have the same input fields as your HTML form in Part 3.

## Part 6 - Submit your Razor form

Add a new action to your `BasicsController` to accept a POST from your Razor form in `Razor.cshtml`. (again, set a breakpoint in your controller).

## Part 7 - New API Controller

Create a new **empty** API Controller named, `AngularApiController`.

## Part 8 - Create a new controller action and Angular driven form

Add a new action to your `BasicsController` named `Angular` with a view named `Angular.cshtml`.


## Part 8 - API Controller actions

Add a `Post` action to your `AngularApiController`. (The action should accept the `dynamic` type as it's argument).

## Part 9 - Create a new Angular Controller and Action

Create a new Angular Controller named, `FormController` and give it an action named `formSubmit()`. This controller should be attached to your `Angular.cshtml`.

## Part 10 - Create an Angular Driven Form

In your new view named, `Angular.cshtml` create an HTML form like in Part #3. Instead of using a HTML submit input type, use an `<button>` tag with an `ng-click`.


## Part 11 - Submit Form using Angular

Capture all the data from your form. Submit the data to the `Post` method in your `AngularApiController` via an AJAX call.

## Part 12 - Do it Again!

Delete your entire codebase and walk-through steps 1 through 11.
