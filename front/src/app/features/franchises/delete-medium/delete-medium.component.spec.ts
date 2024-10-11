import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteMediumComponent } from './delete-medium.component';

describe('DeleteMediumComponent', () => {
  let component: DeleteMediumComponent;
  let fixture: ComponentFixture<DeleteMediumComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DeleteMediumComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DeleteMediumComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
