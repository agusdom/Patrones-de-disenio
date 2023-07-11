using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public public class CompositeCommand : ICommand{
 private List<ICommand> commands;
 
 public CompositeCommand(){
  commands = new List<ICommand>();
 }
 
 public void AddCommand(ICommand command){
  commands.Add(command);
 }

 public async Task Execute(){
  var tasks = new List<Task>();
  for(var command in commads){
    tasks.Add(command.Execute());
  }

 await Task.WhenAll(tasks);
 }
}